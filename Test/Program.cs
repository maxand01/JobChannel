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

            //Console.WriteLine("Test DAL");
            //DALOffre offre = new DALOffre();
            //List<Offre> offres = offre.GetAll();
            //foreach (Offre objOffre in offres )
            //{
            //    Console.WriteLine(objOffre.Region.NomRegion);
            //}

            //Console.WriteLine("Test BLL");
            //Controleur controleur = new Controleur();
            //List<Offre> offres = controleur.GetAll();
            //foreach (Offre offre in offres)
            //{
            //    Console.WriteLine(offre.Region.NomRegion);
            //}

            //Console.WriteLine("Test DAL");
            //DALOffre offre = new DALOffre();
            //List<Offre> offres = offre.GetOffresByPoste("1");
            //foreach (Offre objOffre in offres)
            //{
            //    Console.WriteLine(objOffre.Region.NomRegion);
            //}

            Console.WriteLine("Test Insert");
            DALOffre offre = new DALOffre();
                int offres = offre.AddOffre(0,1,1,1,1,"test","wbdfb","13/02/2015","bwbdsb");
            Console.WriteLine(offres);
            Console.ReadKey();

        }		
    }
}
