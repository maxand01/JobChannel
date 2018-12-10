using BOJobChannel;
using DALJobChannel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DALTypePoste tp = new DALTypePoste();
            List<TypePoste> g = tp.GetAllTypePostes();
            foreach(TypePoste f in g)
            {
                Console.WriteLine(f.IDTypePoste + f.NomPoste);
            }
            Console.ReadKey();

        }		
    }
}
