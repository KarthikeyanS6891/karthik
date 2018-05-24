using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;
using System.Linq;

namespace XMLParsingToList.Models
{
    public class WritePDFFile
    {
        private static int _numberOfCharsToKeep = 15;

        public void WritePDFFiles()
        {
            string oldFile = @"C:\Users\karthikeyan.s85.ITLINFOSYS\Downloads\Sample.pdf";
            string newFile = @"C:\Users\karthikeyan.s85.ITLINFOSYS\Downloads\Output.pdf";

            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);

            // open the writer
            FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            // the pdf content
            PdfContentByte cb = writer.DirectContent;

            // select the font properties
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 8);

            // write the text in the pdf content
            cb.BeginText();
            string text = "Some random blablablabla...";
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 520, 640, 0);
            cb.EndText();
            cb.BeginText();
            text = "Other random blabla...";
            // put the alignment and coordinates here
            cb.ShowTextAligned(2, text, 100, 200, 0);
            cb.EndText();

            // create the new page and add it to the pdf
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            // close the streams and voilá the file should be changed :)
            document.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }

        public void WriteValuesInExistingPdf()
        {
            using (var reader = new PdfReader(@"C:\Users\karthikeyan.s85\Downloads\form13.pdf"))
            {
                using (var fileStream = new FileStream(@"C:\Users\karthikeyan.s85\Downloads\Output.pdf", FileMode.Create, FileAccess.Write))
                {
                    var document = new Document(reader.GetPageSizeWithRotation(1));
                    var writer = PdfWriter.GetInstance(document, fileStream);

                    document.Open();

                    for (var i = 1; i <= reader.NumberOfPages; i++)
                    {
                        document.NewPage();

                        var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        var importedPage = writer.GetImportedPage(reader, i);

                        var contentByte = writer.DirectContent;
                        contentByte.BeginText();
                        contentByte.SetFontAndSize(baseFont, 12);

                        var multiLineString = "Hello World!".Split('\n');

                        foreach (var line in multiLineString)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, line, 200, 200, 0);
                        }

                        contentByte.EndText();
                        contentByte.AddTemplate(importedPage, 0, 0);
                    }

                    document.Close();
                    writer.Close();
                }
            }
        }

        public bool ExtractText(string inFileName, string outFileName)
        {
            StreamWriter outFile = null;
            try
            {
                // Create a reader for the given PDF file
                PdfReader reader = new PdfReader(inFileName);
                //outFile = File.CreateText(outFileName);
                outFile = new StreamWriter(outFileName, false, System.Text.Encoding.UTF8);

                //Console.Write("Processing: ");

                int totalLen = 68;
                float charUnit = ((float)totalLen) / (float)reader.NumberOfPages;
                int totalWritten = 0;
                float curUnit = 0;

                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    outFile.Write(ExtractTextFromPDFBytes(reader.GetPageContent(page)) + " ");

                    // Write the progress.
                    if (charUnit >= 1.0f)
                    {
                        for (int i = 0; i < (int)charUnit; i++)
                        {
                            Console.Write("#");
                            totalWritten++;
                        }
                    }
                    else
                    {
                        curUnit += charUnit;
                        if (curUnit >= 1.0f)
                        {
                            for (int i = 0; i < (int)curUnit; i++)
                            {
                                Console.Write("#");
                                totalWritten++;
                            }
                            curUnit = 0;
                        }

                    }
                }

                if (totalWritten < totalLen)
                {
                    for (int i = 0; i < (totalLen - totalWritten); i++)
                    {
                        Console.Write("#");
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (outFile != null) outFile.Close();
            }
        }

        public string ExtractTextFromPDFBytes(byte[] input)
        {
            if (input == null || input.Length == 0) return "";

            try
            {
                string resultString = "";

                // Flag showing if we are we currently inside a text object
                bool inTextObject = false;

                // Flag showing if the next character is literal 
                // e.g. '\\' to get a '\' character or '\(' to get '('
                bool nextLiteral = false;

                // () Bracket nesting level. Text appears inside ()
                int bracketDepth = 0;

                // Keep previous chars to get extract numbers etc.:
                char[] previousCharacters = new char[_numberOfCharsToKeep];
                for (int j = 0; j < _numberOfCharsToKeep; j++) previousCharacters[j] = ' ';


                for (int i = 0; i < input.Length; i++)
                {
                    char c = (char)input[i];
                    if (input[i] == 213)
                        c = "'".ToCharArray()[0];

                    if (inTextObject)
                    {
                        // Position the text
                        if (bracketDepth == 0)
                        {
                            if (CheckToken(new string[] { "TD", "Td" }, previousCharacters))
                            {
                                resultString += "\n\r";
                            }
                            else
                            {
                                if (CheckToken(new string[] { "'", "T*", "\"" }, previousCharacters))
                                {
                                    resultString += "\n";
                                }
                                else
                                {
                                    if (CheckToken(new string[] { "Tj" }, previousCharacters))
                                    {
                                        resultString += " ";
                                    }
                                }
                            }
                        }

                        // End of a text object, also go to a new line.
                        if (bracketDepth == 0 &&
                            CheckToken(new string[] { "ET" }, previousCharacters))
                        {

                            inTextObject = false;
                            resultString += " ";
                        }
                        else
                        {
                            // Start outputting text
                            if ((c == '(') && (bracketDepth == 0) && (!nextLiteral))
                            {
                                bracketDepth = 1;
                            }
                            else
                            {
                                // Stop outputting text
                                if ((c == ')') && (bracketDepth == 1) && (!nextLiteral))
                                {
                                    bracketDepth = 0;
                                }
                                else
                                {
                                    // Just a normal text character:
                                    if (bracketDepth == 1)
                                    {
                                        // Only print out next character no matter what. 
                                        // Do not interpret.
                                        if (c == '\\' && !nextLiteral)
                                        {
                                            resultString += c.ToString();
                                            nextLiteral = true;
                                        }
                                        else
                                        {
                                            if (((c >= ' ') && (c <= '~')) ||
                                                ((c >= 128) && (c < 255)))
                                            {
                                                resultString += c.ToString();
                                            }

                                            nextLiteral = false;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Store the recent characters for 
                    // when we have to go back for a checking
                    for (int j = 0; j < _numberOfCharsToKeep - 1; j++)
                    {
                        previousCharacters[j] = previousCharacters[j + 1];
                    }
                    previousCharacters[_numberOfCharsToKeep - 1] = c;

                    // Start of a text object
                    if (!inTextObject && CheckToken(new string[] { "BT" }, previousCharacters))
                    {
                        inTextObject = true;
                    }
                }

                return CleanupContent(resultString);
            }
            catch
            {
                return "";
            }
        }

        private string CleanupContent(string text)
        {
            string[] patterns = { @"\\\(", @"\\\)", @"\\226", @"\\222", @"\\223", @"\\224", @"\\340", @"\\342", @"\\344", @"\\300", @"\\302", @"\\304", @"\\351", @"\\350", @"\\352", @"\\353", @"\\311", @"\\310", @"\\312", @"\\313", @"\\362", @"\\364", @"\\366", @"\\322", @"\\324", @"\\326", @"\\354", @"\\356", @"\\357", @"\\314", @"\\316", @"\\317", @"\\347", @"\\307", @"\\371", @"\\373", @"\\374", @"\\331", @"\\333", @"\\334", @"\\256", @"\\231", @"\\253", @"\\273", @"\\251", @"\\221" };
            string[] replace = { "(", ")", "-", "'", "\"", "\"", "à", "â", "ä", "À", "Â", "Ä", "é", "è", "ê", "ë", "É", "È", "Ê", "Ë", "ò", "ô", "ö", "Ò", "Ô", "Ö", "ì", "î", "ï", "Ì", "Î", "Ï", "ç", "Ç", "ù", "û", "ü", "Ù", "Û", "Ü", "®", "™", "«", "»", "©", "'" };

            for (int i = 0; i < patterns.Length; i++)
            {
                string regExPattern = patterns[i];
                Regex regex = new Regex(regExPattern, RegexOptions.IgnoreCase);
                text = regex.Replace(text, replace[i]);
            }

            return text;
        }

        private bool CheckToken(string[] tokens, char[] recent)
        {
            foreach (string token in tokens)
            {
                if ((recent[_numberOfCharsToKeep - 3] == token[0]) &&
                    (recent[_numberOfCharsToKeep - 2] == token[1]) &&
                    ((recent[_numberOfCharsToKeep - 1] == ' ') ||
                    (recent[_numberOfCharsToKeep - 1] == 0x0d) ||
                    (recent[_numberOfCharsToKeep - 1] == 0x0a)) &&
                    ((recent[_numberOfCharsToKeep - 4] == ' ') ||
                    (recent[_numberOfCharsToKeep - 4] == 0x0d) ||
                    (recent[_numberOfCharsToKeep - 4] == 0x0a))
                    )
                {
                    return true;
                }
            }
            return false;
        }

        public List<myKey> ReadPdfFile(string fileName)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                PdfReader pdfReader = new PdfReader(fileName);
                //PdfStamper pdfStamp = new PdfStamper(pdfReader, ms);
                AcroFields fields = pdfReader.AcroFields;
                List<String> Keys = new List<string>();
                List<myKey> Keys1 = new List<myKey>();
                Boolean empty = true;
                foreach (var field in fields.Fields)
                {
                    empty = false;
                    Keys.Add(RemoveLastWords(field.Key, 2, ' '));
                }
                if (empty) return Keys1;
                foreach (String k in Keys)
                {
                    fields.SetField(k, "Testing");
                }

                XfaForm xfa = fields.Xfa;
                string xmllst = xfa.DatasetsNode.InnerXml;
                XDocument doc = XDocument.Parse(xmllst);
                var results = doc.Descendants().Select(x => new
                {
                    name = x.Name,
                    va = x.Value
                }).ToList();

                List<myKey> keyValues = getKeys(fields);

                if (xfa.XfaPresent)
                {
                    System.Xml.XmlNode n = xfa.DatasetsNode.FirstChild;
                    Keys1.AddRange(BFS(n));
                }
                //return Keys;

                pdfReader.Close();
                //pdfStamp.FormFlattening = true;
                //pdfStamp.FreeTextFlattening = true;
                //pdfStamp.Writer.CloseStream = false;

                return Keys1;
            }
        }

        public List<myKey> getKeys(AcroFields af)
        {
            XfaForm xfa = af.Xfa;
            List<myKey> Keys = new List<myKey>();
            foreach (var field in af.Fields)
            {
                Keys.Add(new myKey(field.Key, af.GetField(field.Key)));
            }
            if (xfa.XfaPresent)
            {
                System.Xml.XmlNode n = xfa.DatasetsNode.FirstChild;
                Keys.AddRange(BFS(n));
            }
            return Keys;
        }

        public List<myKey> BFS(System.Xml.XmlNode n)
        {
            List<myKey> Keys = new List<myKey>();
            System.Xml.XmlNode n2 = n;

            if (n == null) return Keys;

            if (n.FirstChild == null)
            {
                n2 = n;
                if ((n2.Name.ToCharArray(0, 1))[0] == '#') n2 = n2.ParentNode;
                while ((n2 = n2.NextSibling) != null)
                {
                    Keys.Add(new myKey(n2.Name, n2.Value));
                }
            }

            if (n.FirstChild != null)
            {
                n2 = n.FirstChild;
                Keys.AddRange(BFS(n2));
            }
            n2 = n;
            while ((n2 = n2.NextSibling) != null)
            {
                Keys.AddRange(BFS(n2));
            }
            return Keys;
        }

        

        public string RemoveLastWords(string input, int numberOfLastWordsToBeRemoved, char delimitter)
        {
            string[] words = input.Split(new[] { delimitter });
            words = words.Reverse().ToArray();
            words = words.Skip(numberOfLastWordsToBeRemoved).ToArray();
            words = words.Reverse().ToArray();
            string output = String.Join(delimitter.ToString(), words);
            return output;
        }

        //public void ConvertXMLToList()
        //{
        //    List<XmlNode> nodes = new List<XmlNode>();
        //    foreach (XmlNode node in XmlNodeList)
        //    {
        //        nodes.Add(node);
        //    }
        //}
    }
}