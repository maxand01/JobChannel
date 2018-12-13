using BLLJobChannel;
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
            //int cb = et.UpdateEntreprise(2,"Test");
            //Console.WriteLine(cb);

            Console.WriteLine("Entreprise"); 
            List<Entreprise> te = et.GetAllEntreprises();
            foreach (Entreprise item in te)
            {
                Console.WriteLine(item.IDEntreprise + " " + item.NomEntreprise + " " + item.NumeroEntreprise + " "+ item.ContactEntreprise);
            }


            DALOffre of = new DALOffre();
            List<Offre> o = of.GetAll();
            foreach (Offre os in o )
            {
                Console.WriteLine(os.IDRegion);
            }

            Controleur ct = new Controleur();
            List<Offre> ob = ct.GetAll();
            foreach (Offre oq in ob)
            {
                Console.WriteLine(oq.Region.NomRegion);
            }
             
            Console.ReadKey();

        }		
    }
}
