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
        private static string URL_SERVICE = "http://user08.2isa.org/ServiceSalarie.svc";

        private RestClient Client = new RestClient(URL_SERVICE);

        public Controleur()
        {

        }

        public List<TypeContrat> GetAllTypeContrats()
        {
            List<TypeContrat> listeContrat = null;
            var request = new RestRequest("TypeContrat?format=json", Method.GET);
            var response = Client.Execute<List<TypeContrat>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                listeContrat = response.Data;
            }
            return listeContrat;
        }
    }
}
