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
    }
}
