using System;

namespace Prototype
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo Id { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Id = new IdInfo(Id.IdNumber);
            clone.Name = new string(Name);
            return clone;
        }
    }
}
