using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Engineer : Employee
    {
        public float N { get; set; }
        public Engineer() : base()
        {
            FinalPrice = FinalPrice + (4.8 * N);
        }
    }
}
