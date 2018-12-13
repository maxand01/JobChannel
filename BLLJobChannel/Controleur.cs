using BOJobChannel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceJobChannel;

namespace BLLJobChannel
{
    public class Controleur
    {
        private static string URL_SERVICE = "http://user18.2isa.org/ServiceJobChannel.svc";

        private RestClient Client = new RestClient(URL_SERVICE);

        public Controleur()
        {

        }

        public List<TypeContrat> GetAllTypeContrats()
        {
            List<TypeContrat> listeContrat = new List<TypeContrat>();
            var request = new RestRequest("TypeContrat?format=json", Method.GET);
            var response = Client.Execute<List<TypeContrat>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeContrat = response.Data;
            }
            return listeContrat;
        }
        public List<TypePoste> GetAllTypePostes()
        {
            List<TypePoste> listePoste = new List<TypePoste>();
            var request = new RestRequest("TypePoste?format=json", Method.GET);
            var response = Client.Execute<List<TypePoste>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listePoste = response.Data;
            }
            return listePoste;
        }
        public List<Region> GetAllRegions()
        {
            List<Region> listeRegion = new List<Region>();
            var request = new RestRequest("Region?format=json", Method.GET);
            var response = Client.Execute<List<Region>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeRegion = response.Data;
            }
            return listeRegion;
        }
        public List<Entreprise> GetAllEntreprises()
        {
            List<Entreprise> listeEntreprise = new List<Entreprise>();
            var request = new RestRequest("Entreprise?format=json", Method.GET);
            var response = Client.Execute<List<Entreprise>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeEntreprise = response.Data;
            }
            return listeEntreprise;
        }
        public List<Offre> GetAllOffres()
        {
            List<Offre> listeOffre = new List<Offre>();
            var request = new RestRequest("Offre?format=json", Method.GET);
            var response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeOffre = response.Data;
            }
            return listeOffre;
        }

        public List<Offre> GetAll()
        {
            List<Offre> listeOffre = new List<Offre>();
            var request = new RestRequest("All?format=json", Method.GET);
            var response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeOffre = response.Data;
            }
            return listeOffre;
        }
    }
}
