using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using XmlToEntityExemple.Classes;
using XmlToEntityExemple.Entities;
using XmlToEntityExemple.FileReader.Contract;

namespace XmlToEntityExemple.FileReader.Implementation.Xml
{
    public class ConverterXml<T> : AConverter<T>
        where T: class
    {
        public string TableName { get; private set; }

        public ConverterXml(string tableName)
        {
            TableName = tableName;
        }

        public override IEnumerable<T> ReadEntities(string filePath)
        {
            XmlDocument xmlContent = new XmlDocument();
            xmlContent.Load(filePath);

            XmlNodeList elemList = xmlContent.GetElementsByTagName("ROW");

            foreach (XmlNode item in elemList)
                yield return XmlInterpreter.DeserializeObject<T>(item.OuterXml);
        }

        public override void Validate(string filePath)
        {
            if (!filePath.ToLower().EndsWith(".xml"))
                throw new InvalidOperationException("Selected file inválid. Please, select only .xml files.");
        }
    }
}
