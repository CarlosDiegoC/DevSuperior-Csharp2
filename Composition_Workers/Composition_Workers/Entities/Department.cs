
namespace Composition_Workers.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }

        public Department(string name) : this()
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Department: " + Name;
        }

    }
}
