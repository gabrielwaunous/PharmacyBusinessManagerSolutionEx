using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ClaimImportTool.Infrastructure.Serializers
{
    public class XmlClaimSerializer : IClaimSerializer
    {
        public IEnumerable<ClaimDTO> GetClaimFromString(string claimString)
        {

            ClaimList cars = null;
            XmlSerializer serializer = new XmlSerializer(typeof(ClaimList));

            StreamReader reader = new StreamReader(@"ClaimSource.xml");
            cars = (ClaimList)serializer.Deserialize(reader);
            reader.Close();

            return (IEnumerable<ClaimDTO>)cars;

        }


    }
}

[Serializable()]
public class ClaimXmlDTO
{
    [System.Xml.Serialization.XmlElement("Type")]    
    string Type { get; set; }
    [System.Xml.Serialization.XmlElement("DOI")]
    string DOI { get; set; }
    [System.Xml.Serialization.XmlElement("Number")]
    string Number { get; set; }
    [System.Xml.Serialization.XmlElement("Claimant")]
    string Claimant { get; set; }
    //ClaimXmlDictionary<string, string> Claimant { get; set; }
}

[Serializable()]
[System.Xml.Serialization.XmlRoot("ClaimList")]
public class ClaimList
{
    [XmlArray("Claim")]
    [XmlArrayItem("Claim", typeof(ClaimXmlDTO))]
    public ClaimXmlDTO[] Claim { get; set; }
}