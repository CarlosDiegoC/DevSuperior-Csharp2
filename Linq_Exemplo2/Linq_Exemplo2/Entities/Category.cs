using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Exemplo2.Entities
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }

        public Category()
        {
        }

        public Category(int id, string name, int tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Tier: " + Tier;
        }
    }
}
