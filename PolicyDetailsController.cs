using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using XMLParsingToList.Models;

namespace XMLParsingToList.Controllers
{
    public class PolicyDetailsController : Controller
    {
        TempClass tempClass = new TempClass();
        WritePDFFile objWriteFile = new WritePDFFile();
        // GET: PolicyDetails
        public ActionResult Index()
        {
            if (TempData["policyData"] == null)
            {
                ViewBag.ShowList = false;
                return View();
            }
            else
            {
                PolicyDetailModel lst = (PolicyDetailModel)TempData["policyData"];
                ViewBag.ShowList = true;
                return View(lst);
            }
        }

        public ActionResult GetPDFDetails()
        {
            //List<string> values = objWriteFile.ReadPdfFile(@"C:\Users\karthikeyan.s85\Downloads\OoPdfFormExample.pdf");

            //ViewBag.TextFound = values;

            return View();
        }

        [HttpPost]
        public ActionResult Savefile()
        {
            //var file = Request.Files[0];
            //if (file != null && file.ContentLength > 0)
            //{
            //    XmlDocument xmlDocument = new XmlDocument();
            //    xmlDocument.Load(file.InputStream);

            //    tempClass.TempFunction("C:\\Users\\karthikeyan.s85\\Downloads\\Form13.pdf", xmlDocument);

            //}
            //return View();
            foreach (string file in Request.Files)
            {
                HttpPostedFileBase fileContent = Request.Files[file];
                fileContent.SaveAs(System.IO.Path.Combine(System.IO.Path.GetTempPath(), "processedXML.xml"));
            }
            return View();
        }

        //[HttpPost]
        //public ActionResult Savefile1()
        //{
        //    //var file = Request.Files[0];
        //    //if (file != null && file.ContentLength > 0)
        //    //{
        //    //    XmlDocument xmlDocument = new XmlDocument();
        //    //    xmlDocument.Load(file.InputStream);

        //    //    tempClass.TempFunction("C:\\Users\\karthikeyan.s85\\Downloads\\Form13.pdf", xmlDocument);

        //    //}
        //    //return View();
        //    foreach (string file in Request.Files)
        //    {
        //        HttpPostedFileBase fileContent = Request.Files[file];
        //        string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "processedPDF.pdf");
        //        fileContent.SaveAs(path);
        //        GetPDF(path);
        //    }
        //    return View();
        //}

        [HttpPost]
        public ActionResult Upload()
        {
            Enrollment model = new Enrollment();

            try
            {
                //List<PolicyDetailModel> userList = new List<PolicyDetailModel>();

                //FileStream fs = new FileStream(System.IO.Path.Combine(System.IO.Path.GetTempPath(), "processedfile.xml"),
                //    FileMode.Open, FileAccess.Read);
                //    HttpPostedFileBase file = fs
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    //XmlDocument xmldoc = new XmlDocument();
                    //xmldoc.Load(@"D:\Karthikeyan Documents\" + file.FileName);
                    //PolicyDetailModel policyDetail;
                    //XmlNodeList usernodes = xmldoc.SelectNodes("/Users/User");
                    //foreach (XmlNode usr in usernodes)
                    //{
                    //    policyDetail = new PolicyDetailModel();
                    //    policyDetail.Id = Convert.ToInt32(usr["id"].InnerText);
                    //    policyDetail.Name = usr["name"].InnerText;
                    //    policyDetail.Gender = usr["gender"].InnerText;
                    //    policyDetail.Mobile = usr["mobile"].InnerText;
                    //    XmlNodeList addrNodes = usr.SelectNodes("address");
                    //    foreach (XmlNode addrn in addrNodes)
                    //    {
                    //        policyDetail.StreetName = addrn["street"].InnerText;
                    //        policyDetail.City = addrn["city"].InnerText;
                    //        policyDetail.Pin = addrn["pincode"].InnerText;
                    //    }
                    //    TempData["policyData"] = policyDetail;
                    //}

                    string xml = System.IO.File.ReadAllText(file.FileName);

                    model = ParseXML<Enrollment>(xml);
                }
            }
            catch (Exception ex)
            {
                var error = ex;
                throw;
            }

            return PartialView("_XMLInTreeview", model);
        }

        public T Deserialize<T>(string input) where T : class
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Enrollment";
            xRoot.IsNullable = true;
            XmlSerializer ser = new XmlSerializer(typeof(T), xRoot);
            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }

        public static Stream ToStream(string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }


        public static T ParseXML<T>(string result) where T : class
        {
            var reader = XmlReader.Create(ToStream(result.Trim()), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }

        //public ActionResult file()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult SaveFile(HttpPostedFileBase file)
        //{
        //    if (file != null && file.ContentLength > 0)
        //    {
        //        try
        //        {
        //            string path = System.IO.Path.Combine(Server.MapPath("~/Content/files"),

        //            System.IO.Path.GetFileName(file.FileName));
        //            file.SaveAs(path);



        //            //  ViewBag.Message = "File uploaded successfully";
        //        }
        //        catch (Exception ex)
        //        {
        //            ViewBag.Message = "ERROR:" + ex.Message.ToString();
        //        }
        //    }
        //    else
        //    {
        //        ViewBag.Message = "You have not specified a file.";
        //    }

        //    return View();
        //}

        //[HttpPost]"C:\\Users\\parthiban.s02\\Desktop\\Form13.pdf"
        //public FileStreamResult GetPDF(HttpPostedFileBase file)
        //public PartialViewResult GetPDF(string pdfFilePath)
        //{
        //    //pdfFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "processedPDF.pdf");
        //    //FileStream fs = new FileStream(@"C:\\Users\\parthiban.s02\\Desktop\\Form13.pdf", FileMode.Open, FileAccess.Read);
        //    //PdfView pdfv = new PdfView();
        //    //pdfv.result = fs;
        //    //fs.Dispose();
        //    byte[] bytes = System.IO.File.ReadAllBytes(@"C:\\Users\\parthiban.s02\\Desktop\\Form13.pdf");
        //    var strBase64 = Convert.ToBase64String(bytes);
        //    PdfView pdfv = new PdfView();
        //    pdfv.result = string.Format("data:application/pdf;base64,{0}", strBase64);
        //    return PartialView("_ShowPDF", pdfv);
        //    //try
        //    //{
        //    //    if (!string.IsNullOrEmpty(pdfFilePath))
        //    //    {
        //    //        FileStream fs = new FileStream(pdfFilePath, FileMode.Open, FileAccess.Read);
        //    //    }
        //    //    else
        //    //    {

        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw ex;
        //    //}
        //    //return PartialView("_ShowPDF");
        //    //return File(fs, "application/pdf");
        //}


        public ActionResult file()
        {
            return View();
        }
        [HttpPost]
        public ActionResult file(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string path = System.IO.Path.Combine(Server.MapPath("~/Content/files"),

                    System.IO.Path.GetFileName(file.FileName));
                    file.SaveAs(path);

                    ViewBag.Message = "File uploaded successfully";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }
            }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }

            return View();
        }

        [HttpPost]
        public ActionResult ShowPDF()
        {
            TempData["PDFFile"] = Request.Files[0].FileName;
            return PartialView("_ShowPDF");
        }
      
        public ActionResult GetPDF()
        {
            string file = TempData["PDFFile"].ToString();
            //byte[] bytes = System.IO.File.ReadAllBytes(file.FileName);
            //var strBase64 = Convert.ToBase64String(bytes);

            //string result = string.Format("data:application/pdf;base64,{0}", strBase64);

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            //string
            return File(fs, "application/pdf");
            //return PartialView("_ShowPDF", result);
        }
    }
}