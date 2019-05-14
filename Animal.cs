using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatPolymorph
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("The Animal Speaks");
        }
    }
}
