using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddingClassExamples
{
    class BloodData
    {
        private string bloodType;
        private string rhFactor;

        //constructor
        public BloodData()
        {
            bloodType = "O";
            rhFactor = "+";
        }
        public BloodData(string btype, string rh)
        {
            bloodType = btype;
            rhFactor = rh;
        }

        public string BloodType
        {
            get
            {
                return bloodType;
            }
            set
            {
                bloodType = value;
            }
        }

        public string RhFactor
        {
            get
            {
                return rhFactor; 
            }
            set
            {
                rhFactor = value;
            }
        }

    }
}
