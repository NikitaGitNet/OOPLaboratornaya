using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employee
    {
        public string Name { get; set; }
        public double StartedPrice { get; set; }
        public double FinalPrice { get; set; }
        protected double Coefficient = 1.5;
        public Employee()
        {

        }
        public Employee(string Name, double StartedPrice)
        {
            this.Name = Name;
            this.StartedPrice = StartedPrice;
            FinalPrice = StartedPrice * Coefficient;
        }
    }
}
