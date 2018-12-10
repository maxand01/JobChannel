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

            DALEntreprise et = new DALEntreprise();
            int cb = et.UpdateEntreprise(2,"Test");
            Console.WriteLine(cb);

            DALOffre of = new DALOffre();
            List<Offre> o = of.GetAllOffres();
            foreach (Offre os in o )
            {
                Console.WriteLine(os.TitreOffre);
            }
            Console.ReadKey();

        }		
    }
}
