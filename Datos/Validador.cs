using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Validador
    {
        public Boolean esEntero(String n)
        {
            int m;
            if(int.TryParse(n, out m))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean esDecimal(String n)
        {
            Decimal f;
            if(Decimal.TryParse(n, out f))
            {
                if (f / ((int) f) == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        
        public Boolean esEdad(String n)
        {
            int d;
            if(int.TryParse(n, out d))
            {
                if (d > 0 && d < 110)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public Boolean esDigito(String n)
        {
            String nm = n.ToUpper();
            if(nm.Equals("UNO")|| nm.Equals("DOS")|| nm.Equals("TRES")|| nm.Equals("CUATRO")|| nm.Equals("CINCO")|| nm.Equals("SEIS")|| nm.Equals("SIETE")|| nm.Equals("OCHO")|| nm.Equals("NUEVE"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
