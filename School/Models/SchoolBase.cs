using System;

namespace School.Models
{
    public abstract class SchoolBase
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name},{Id}";
        }
    }
}