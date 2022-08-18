using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moebler
{
    internal class TV : Moebel
    {
        public int Stoerrelse;
        
        public override void Udskriv()
        {        
            base.Udskriv();
            Console.WriteLine($"- og har en skærm på {Stoerrelse} tommer");
        }
    }
}
