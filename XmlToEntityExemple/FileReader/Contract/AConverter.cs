using System.Collections.Generic;

namespace XmlToEntityExemple.FileReader.Contract
{
    public abstract class AConverter<T>
        where T: class
    {
        public abstract void Validate(string filePath);
        public abstract IEnumerable<T> ReadEntities(string filePath);
    }
}
