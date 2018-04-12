using System;
using System.Collections.Generic;
using XmlToEntityExemple.Contract;
using XmlToEntityExemple.FileReader.Contract;

namespace XmlToEntityExemple.FileReader.Implementation
{
    public class ReadClientToDatabase<T> : AFileReader<T>
        where T : class
    {
        public ReadClientToDatabase(AConverter<T> converter) 
            : base(converter)
        {
        }

        protected override void ProcessEntities(List<T> entities)
        {
            Console.WriteLine("Recording entities..." + entities.Count);
        }
    }
}
