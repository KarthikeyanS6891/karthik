using System;
using System.Collections.Generic;
using System.Linq;
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
            List<myKey> values = objWriteFile.ReadPdfFile(@"D:\Karthikeyan Documents\Sample.pdf");

            ViewBag.TextFound = values;

            return View();
        }

        public ActionResult GetXMLNodes()
        {
            return View();
        }

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