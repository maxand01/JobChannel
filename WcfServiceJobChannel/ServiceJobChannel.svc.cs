using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BOJobChannel;
using DALJobChannel;

namespace WcfServiceJobChannel
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceJobChannel : IServiceJobChannel
    {
        public int AddOffre(Offre offre)
        {
            return new DALOffre().AddOffre(offre.IDOffre, offre.IDRegion, offre.IDTypeContrat, offre.IDTypePoste, offre.IDEntreprise, offre.TitreOffre, offre.DescriptionOffre, offre.DateOffre, offre.LienWeb);
        }

        public List<Offre> GetAll()
        {
            return new DALOffre().GetAll();
        }

        public List<Entreprise> GetAllEntreprises()
        {
            return new DALEntreprise().GetAllEntreprises();
        }

        public List<Offre> GetAllOffres()
        {
            return new DALOffre().GetAllOffres();
        }

        public List<Region> GetAllRegions()
        {
            return new DALRegion().GetAllRegions();
        }

        public List<TypeContrat> GetAllTypeContrats()
        {
            return new DALTypeContrat().GetAllTypeContrats();
        }

        public List<TypePoste> GetAllTypePostes()
        {
            return new DALTypePoste().GetAllTypePostes();
        }

        public List<Offre> GetOffresByContrat(string idTypeContrat)
        {
            return new DALOffre().GetOffresByContrat(idTypeContrat);
        }

        public List<Offre> GetOffresByEntreprise(string idTypeEntreprise)
        {
            return new DALOffre().GetOffresByEntreprise(idTypeEntreprise);
        }

        public List<Offre> GetOffresByPoste(string idTypePoste)
        {
            return new DALOffre().GetOffresByPoste(idTypePoste);
        }

        public List<Offre> GetOffresByRegion(string idRegion)
        {
            return new DALOffre().GetOffresByRegion(idRegion);
        }

        public int UpdateEntreprise(Entreprise entreprise)
        {
            return new DALEntreprise().UpdateEntreprise(entreprise.IDEntreprise, entreprise.ContactEntreprise);
        }

        public int UpdateOffre(Offre offre)
        {
            return new DALOffre().UpdateOffre(offre.IDOffre, offre.IDRegion, offre.IDTypeContrat, offre.IDTypePoste, offre.IDEntreprise, offre.TitreOffre, offre.DescriptionOffre, offre.DateOffre, offre.LienWeb) ;
        }
    }
}
