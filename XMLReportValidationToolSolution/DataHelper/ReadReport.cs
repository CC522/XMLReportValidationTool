using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DataHelper
{
    public class ReadReport
    {
        XmlDocument xmlDoc = new XmlDocument();

        public string CheckStatusByName(string strStatusName, string strFileName) {
            String strStatusValue = null;
            xmlDoc.Load(strFileName);
            strStatusValue = xmlDoc.SelectSingleNode(strStatusName).InnerText;
            return strStatusValue;
        }
    }
}
