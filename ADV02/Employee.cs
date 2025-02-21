using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
    class EmpName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Name?.CompareTo(y?.Name) ?? (y is null ? 0 : -1);
        }
    }
    class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary)
        {
            this.ID = id;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Salary: {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (other == null)
                return 1;
            return this.ID.CompareTo(other.ID);
        }
    }
}
