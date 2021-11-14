using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor
    {
        public int i;
        public static string Rotorstellung(Rotor r1,Rotor r2,Rotor r3,int n)
        {
            string output = string.Empty;
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int position = Array.IndexOf(alpha,n);
            output = alpha[Math.Abs(position)].ToString();


            return output;
        }
        public static string Rotorstellung2(dynamic n)
        {
            
            string output = string.Empty;
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            output=Convert.ToString(alpha[n]);

            return output;
        }

    }
}
