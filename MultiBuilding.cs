using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    sealed class MultiBuilding : Building
    {
        int numberOfStoreys;
        int NumberOfStoreys
        {
            get { return numberOfStoreys; }
            set
            {
                if (value > 0)
                    numberOfStoreys = value;
                else
                    numberOfStoreys = 1;
            }
        }
        public MultiBuilding(string s, int l, int w, int h, int n)
             : base(s, l, w, h)
        {
            NumberOfStoreys = n;
        }
        public string Print()
        {
            return base.Print() + ", Количество этажей: " + NumberOfStoreys;
        }
    }

}
