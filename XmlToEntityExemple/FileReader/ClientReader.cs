using System;
using System.Collections.Generic;
using XmlToEntityExemple.Entities;
using XmlToEntityExemple.FileReader.Contract;
using XmlToEntityExemple.FileReader.Implementation;

namespace XmlToEntityExemple.FileReader
{
    public class ClientReader
    {
        ReadClientToDatabase<ClientInfo> _clientReader;

        public ClientReader(AConverter<ClientInfo> converter)
        {
            _clientReader = new ReadClientToDatabase<ClientInfo>(converter);
        }

        public List<ClientInfo> ProcessFile(string filePath)
        {
            Console.WriteLine($"Processing the file {filePath}");
            return _clientReader.Process(filePath);
            Console.WriteLine($"File {filePath} processed !");
        }
    }
}
