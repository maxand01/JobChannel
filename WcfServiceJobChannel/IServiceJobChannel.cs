using BOJobChannel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceJobChannel
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceJobChannel
    {
        [OperationContract]
        [WebGet(UriTemplate = "TypeContrat?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<TypeContrat> GetAllTypeContrats();

        [OperationContract]
        [WebGet(UriTemplate = "TypePoste?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<TypePoste> GetAllTypePostes();

        [OperationContract]
        [WebGet(UriTemplate = "Region?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Region> GetAllRegions();

        [OperationContract]
        [WebGet(UriTemplate = "Entreprise?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Entreprise> GetAllEntreprises();

        [OperationContract]
        [WebGet(UriTemplate = "Offre?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetAllOffres();

        [OperationContract]
        [WebGet(UriTemplate = "All?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetOffresByPoste/{idTypePoste}?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffresByPoste(string idTypePoste);

        [OperationContract]
        [WebGet(UriTemplate = "GetOffresByContrat/{idTypeContrat}?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffresByContrat(string idTypeContrat);

        [OperationContract]
        [WebGet(UriTemplate = "GetOffresByEntreprise/{idEntreprise}?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffresByEntreprise(string idTypeEntreprise);

        [OperationContract]
        [WebGet(UriTemplate = "GetOffresByRegion/{idRegion}?format=json", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffresByRegion(string idRegion);

        [OperationContract]
        [WebInvoke(UriTemplate = "Entreprise", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int UpdateEntreprise(Entreprise entreprise);

        [OperationContract]
        [WebInvoke(UriTemplate = "Offre", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int UpdateOffre(Offre offre);

        [OperationContract]
        [WebInvoke(UriTemplate = "AjouterOffre", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int AddOffre(Offre offre);
        // TODO: ajoutez vos opérations de service ici
    }    
}
