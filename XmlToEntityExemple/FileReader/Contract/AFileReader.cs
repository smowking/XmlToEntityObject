using System.Collections.Generic;
using System.Linq;
using XmlToEntityExemple.FileReader.Contract;

namespace XmlToEntityExemple.Contract
{
    public abstract class AFileReader<T>
        where T: class
    {
        AConverter<T> _converter;

        protected abstract void ProcessEntities(List<T> entities);

        public AFileReader(AConverter<T> converter)
        {
            _converter = converter;
        }

        protected virtual List<T> ConvertFile(string filePath)
        {
            return _converter.ReadEntities(filePath).ToList();
        }

        protected virtual void Validate(string filePath)
        {
            _converter.Validate(filePath);
        }

        public List<T> Process(string filePath)
        {
            Validate(filePath);
            var entities = ConvertFile(filePath);

            ProcessEntities(entities);

            return entities;
        }
    }
}
