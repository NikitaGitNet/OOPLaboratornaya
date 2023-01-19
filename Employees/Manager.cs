using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Manager : Employee
    {
        public float SalesNormal = 100;
        public float SalesVolume { get; set; }
        public Manager(float SalesVolume) : base()
        {
            this.SalesVolume = SalesVolume;
            if (SalesVolume >= SalesNormal)
            {
                FinalPrice += FinalPrice / 100 * 1;
            }
        }

    }
}
