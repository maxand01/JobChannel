using BOJobChannel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public int UpdateOffre(Offre offre)
        {
            int resultat = 0;
            var request = new RestRequest("Offre", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(offre);
            var response = Client.Execute<int>(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                resultat = response.Data;
            }
            return resultat;
        }
        public int AddOffre(Offre offre)
        {
            int resultat = 0;
            var request = new RestRequest("Offre", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(offre);
            var response = Client.Execute<int>(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                resultat = response.Data;
            }
            return resultat;
        }
        public List<Offre> GetOffresByPoste(string idTypePoste)
        {
            List<Offre> listeOffre = null;
            var request = new RestRequest("GetOffresByPoste/{idTypePoste}?format=json", Method.GET);
            request.AddParameter("idTypePoste", idTypePoste, ParameterType.UrlSegment);
            var response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeOffre = response.Data;
            }
            return listeOffre;

        }
        public List<Offre> GetOffresByContrat(string idTypeContrat)
        {
            List<Offre> listeOffre = null;
            var request = new RestRequest("GetOffresByTypeContrat/{idTypeContrat}?format=json", Method.GET);
            request.AddParameter("idTypePoste", idTypeContrat, ParameterType.UrlSegment);
            var response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeOffre = response.Data;
            }
            return listeOffre;
        }

        public List<Offre> GetOffresByEntreprise(string idEntreprise)
        {
            List<Offre> listeOffre = null;
            var request = new RestRequest("GetOffresByEntreprise/{idEntreprise}?format=json", Method.GET);
            request.AddParameter("idTypePoste", idEntreprise, ParameterType.UrlSegment);
            var response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeOffre = response.Data;
            }
            return listeOffre;

        }

        public List<Offre> GetOffresByRegion(string idRegion)
        {
            List<Offre> listeOffre = null;
            var request = new RestRequest("GetOffresByRegion/{idRegion}?format=json", Method.GET);
            request.AddParameter("idTypePoste", idRegion, ParameterType.UrlSegment);
            var response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeOffre = response.Data;
            }
            return listeOffre;

        }
    }
}
