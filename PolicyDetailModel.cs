using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XMLParsingToList.Models
{
    public class PolicyDetailModel
    {
        public int GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Address1 { get; set; }
        public string Mobile { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string result { get; set; }
    }
    public class PdfView
    {
        public string result { get; set; }
    }
}