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

namespace XMLParsingToList.Models
{
    public class TempClass
    {
        public void TempFunction(string m_FormsPath, XmlDocument oXmlData)
        {
            using (MemoryStream stream = GeneratePDF(m_FormsPath, oXmlData))
            {
                byte[] bytes = stream.ToArray();
                HttpContext.Current.Response.ContentType = "application/pdf";
                HttpContext.Current.Response.BinaryWrite(bytes);
                HttpContext.Current.Response.End();
            }
        }
        // <summary>
        // This method combines pdf forms with xml data
        // </summary>
        // <param name="m_FormName">pdf form file path</param>
        // <param name="oData">xml dataset</param>
        // <returns>memory stream containing the pdf data</returns>
        private MemoryStream GeneratePDF(string m_FormName, XmlDocument oData)
        {
            PdfReader pdfTemplate;
            PdfStamper stamper;
            PdfReader tempPDF;
            Document doc;
            MemoryStream msTemp;
            PdfWriter pCopy;
            MemoryStream msOutput = new MemoryStream();

            pdfTemplate = new PdfReader(m_FormName);

            doc = new Document();
            pCopy = new PdfCopy(doc, msOutput);

            pCopy.AddViewerPreference(PdfName.PICKTRAYBYPDFSIZE, new PdfBoolean(true));
            pCopy.AddViewerPreference(PdfName.PRINTSCALING, PdfName.NONE);

            doc.Open();

            for (int i = 1; i < pdfTemplate.NumberOfPages + 1; i++)
            {
                msTemp = new MemoryStream();
                pdfTemplate = new PdfReader(m_FormName);

                stamper = new PdfStamper(pdfTemplate, msTemp);

                // map xml values to pdf form controls (element name = control name)
                foreach (XmlElement oElem in oData.SelectNodes("/Users/User"))
                {
                    stamper.AcroFields.SetField(oElem.Name, oElem.InnerText);
                }

                stamper.FormFlattening = true;
                stamper.Close();
                tempPDF = new PdfReader(msTemp.ToArray());
                ((PdfCopy)pCopy).AddPage(pCopy.GetImportedPage(tempPDF, i));
                pCopy.FreeReader(tempPDF);
            }

            doc.Close();

            return msOutput;
        }

        public string GetTextFromPDF()
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader("C:\\Users\\karthikeyan.s85\\Downloads\\Form13.pdf"))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }

        public string GetReadPDFFile()
        {
            //string TempFilename = System.IO.Path.GetTempFileName();

            PdfReader pdfReader = new PdfReader("C:\\Users\\karthikeyan.s85\\Downloads\\testdoc.pdf");
            ////PdfStamper stamper = new PdfStamper(pdfReader, new FileStream(TempFilename, FileMode.Create));
            //PdfStamper stamper = new PdfStamper(pdfReader, new FileStream(TempFilename, FileMode.Create), '\0', true);

            //AcroFields fields = stamper.AcroFields;
            //AcroFields pdfFormFields = pdfReader.AcroFields;

            //foreach (KeyValuePair<string, AcroFields.Item> kvp in fields.Fields)
            //{
            //    //string FieldValue = GetXMLNode(XMLFile, kvp.Key);
            //    //if (FieldValue != "")
            //    //{
            //        fields.SetField(kvp.Key, kvp.Value.ToString());
            //    //}
            //}

            //stamper.FormFlattening = false;
            //stamper.Close();
            //pdfReader.Close();

            string resultValue = string.Empty;
            var pdf_filename = "C:\\Users\\karthikeyan.s85\\Downloads\\testdoc.pdf";
            using (var reader = new PdfReader(pdf_filename))
            {
                var fields = reader.AcroFields.Fields;
                //string val = fields("fieldname");
                foreach (var key in fields.Keys)
                {
                    var value = reader.AcroFields.GetField(key);
                    resultValue += key + " : " + value;
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var de in pdfReader.AcroFields.Fields)
            {
                sb.Append(de.Key.ToString() + Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}