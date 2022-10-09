using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.Domain.ValueObjects
{
    public sealed class Model : ValueObject<Model>
    {
        public Model(string name)
        {
            Name = name;
        }

        public string Name { get; }
        protected override bool EqualsCore(Model other)
        {
            return Name == other.Name;
        }
    }
}

