using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_4
{
    public class Persona
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"El nombre es: {this.Name}";
        }
    }
}
