using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMLParsingToList.Models
{
    public class RectAndText
    {
        public iTextSharp.text.Rectangle Rect;
        public String Text;
        public RectAndText(iTextSharp.text.Rectangle rect, String text)
        {
            this.Rect = rect;
            this.Text = text;
        }
    }

    public class SampleClass
    {
        public string TextValue { get; set; }
        public float positionLeft { get; set; }
        public float positionBottom { get; set; }
    }

    public class myKey
    {
        private string key;
        private string v;

        public myKey(string key, string v)
        {
            this.key = key;
            this.v = v;
        }
    }
}