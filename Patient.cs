using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbuBolt
{
    public class Patient
    {
        public Patient(string v1, int v2, string v3, string v4)
        {
            Condition = v1;
            Age = v2;
            Diagnosis = v3;
            Description = v4;
        }

        public string Condition { get; set; }

        public int Age { get; set; }

        public string Diagnosis { get; set; }

        public string Description { get; set; }
    }


}
