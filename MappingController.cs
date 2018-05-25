using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using XMLParsingToList.Models;

namespace XMLParsingToList.Controllers
{
    public class MappingController : Controller
    {
        WritePDFFile objWriteFile = new WritePDFFile();
        // GET: Mapping
        public ActionResult Index()
        {
            List<string> values = objWriteFile.ReadPdfFile(@"D:\Karthikeyan Documents\OoPdfFormExample.pdf");

            ViewBag.TextFound = values;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(@"D:\Karthikeyan Documents\testfile1.xml");
            }
            catch (XmlException e)
            {
                throw e;
            }


            foreach (XmlNode node in xmlDoc)
            {
                if (node.NodeType == XmlNodeType.XmlDeclaration)
                {
                    xmlDoc.RemoveChild(node);
                }
            }
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);
            xmlDoc.WriteTo(xw);

            ViewBag.data = sw.ToString();

            return View();
        }

        public ActionResult GetXMLNodes()
        {
            return View();
        }

    //    public ActionResult GetHTMLVersionOfPDF()
    //    {            
    //        using (Stream inputStream = File.OpenRead("../../data/notification.pdf"))
    //        {
    //            using (FixedDocument doc = new FixedDocument(inputStream))
    //            {
    //                // create output file
    //                using (TextWriter writer =
    //new StreamWriter(File.Create("c:/out.html"), Encoding.UTF8))
    //                {
    //                    Page page = doc.Pages[0];
    //                    // write returned html string to file
    //                    writer.Write(page.ConvertToHtml(TextExtractionOptions.HtmlPage));
    //                }
    //            }
    //        }

    //        Process.Start("c:/out.html");

    //        return View();
    //    }

        //[HttpPost]
        //public ActionResult XMLUpload(HttpPostedFileBase file)
        //{
        //    try
        //    {
        //        XmlDocument xmldoc = new XmlDocument();
        //        xmldoc.Load(@"D:\Karthikeyan Documents\testfile1.xml");
        //        PolicyDetailModel policyDetail;
        //        XmlNodeList usernodes = xmldoc.SelectNodes("/Users/User");
        //        foreach (XmlNode usr in usernodes)
        //        {
        //            policyDetail = new PolicyDetailModel();
        //            policyDetail.Id = Convert.ToInt32(usr["id"].InnerText);
        //            policyDetail.Name = usr["name"].InnerText;
        //            policyDetail.Gender = usr["gender"].InnerText;
        //            policyDetail.Mobile = usr["mobile"].InnerText;
        //            XmlNodeList addrNodes = usr.SelectNodes("address");
        //            foreach (XmlNode addrn in addrNodes)
        //            {
        //                policyDetail.StreetName = addrn["street"].InnerText;
        //                policyDetail.City = addrn["city"].InnerText;
        //                policyDetail.Pin = addrn["pincode"].InnerText;
        //            }
        //            TempData["policyData"] = policyDetail;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }


        //}
    }
}