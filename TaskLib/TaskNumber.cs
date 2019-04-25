using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public struct TaskNumber
    {
        public string Prefix { get; set; }
        public string Sufix { get; set; }
        public int Number { get; set; }

        public TaskNumber(string prefix, int nr)
        {
            Prefix = prefix;
            Number = nr;
            Sufix = "";
        }


        public override string ToString()
        {
            return $"{Prefix}/{Number}/{Sufix}";
        }


    }
}
