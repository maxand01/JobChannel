using BOJobChannel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALJobChannel
{
    public class DALOffre
    {
        public string Requete { get; set; }
        public List<Offre> Liste { get; set; }

        private Singleton objSingleton;


        public DALOffre()
        {
            Liste = new List<Offre>();
            objSingleton = Singleton.Instance();

        }
        public List<Offre> GetAllOffres()
        {
            Requete = "Select * from OFFRE order by ID_OFFRE";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                Liste.Add(offre);
            }
            return Liste;
        }
        public List<Offre> GetAll()
        {
            Requete = "Select * from VIEW_ALL order by ID_OFFRE";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                offre.Region.NomRegion = row["NOM_REGION"].ToString();
                offre.TypeContrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                offre.TypePoste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                offre.Entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                Liste.Add(offre);
            }
            return Liste;
        }

        public int UpdateOffre(int idOffre, int idRegion, int idTypeContrat, int idTypePoste, int idEntreprise, string titreOffre, string descriptionOffre, string dateOffre, string lienWeb)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSingleton.Open();
            objSelectCommand.CommandText = "dbo.UpdateOffre";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_OFFRE", idOffre);
            objSelectCommand.Parameters.AddWithValue("@ID_REGION", idRegion);
            objSelectCommand.Parameters.AddWithValue("@ID_TYPE_CONTRAT", idTypeContrat);
            objSelectCommand.Parameters.AddWithValue("@ID_TYPE_POSTE", idTypePoste);
            objSelectCommand.Parameters.AddWithValue("@ID_ENTREPRISE", idEntreprise);
            objSelectCommand.Parameters.AddWithValue("@TITRE_OFFRE", titreOffre);
            objSelectCommand.Parameters.AddWithValue("@DESCRIPTION_OFFRE", descriptionOffre);
            objSelectCommand.Parameters.AddWithValue("@DATE_OFFRE", dateOffre);
            objSelectCommand.Parameters.AddWithValue("@LIEN_WEB", lienWeb);
            int nbLignes = objSingleton.ExecuteNonQuery(objSelectCommand);
            objSingleton.Close();
            return nbLignes;
        }

        public int AddOffre(int idRegion, int idTypeContrat, int idTypePoste, int idEntreprise, string titreOffre, string descriptionOffre, string dateOffre, string lienWeb)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSingleton.Open();
            objSelectCommand.CommandText = "dbo.AddOffre";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_REGION", idRegion);
            objSelectCommand.Parameters.AddWithValue("@ID_TYPE_CONTRAT", idTypeContrat);
            objSelectCommand.Parameters.AddWithValue("@ID_TYPE_POSTE", idTypePoste);
            objSelectCommand.Parameters.AddWithValue("@ID_ENTREPRISE", idEntreprise);
            objSelectCommand.Parameters.AddWithValue("@TITRE_OFFRE", titreOffre);
            objSelectCommand.Parameters.AddWithValue("@DESCRIPTION_OFFRE", descriptionOffre);
            objSelectCommand.Parameters.AddWithValue("@DATE_OFFRE", Convert.ToDateTime(dateOffre));
            objSelectCommand.Parameters.AddWithValue("@LIEN_WEB", lienWeb);
            int nbLignes = objSingleton.ExecuteNonQuery(objSelectCommand);
            objSingleton.Close();
            return nbLignes;
        }

        public List<Offre> GetOffresByPoste(string idTypePoste)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            //objSingleton.Open();
            objSelectCommand.CommandText = "dbo.GetOffresByPoste";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_TYPE_POSTE", idTypePoste);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                offre.Region.NomRegion = row["NOM_REGION"].ToString();
                offre.TypeContrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                offre.TypePoste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                offre.Entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                Liste.Add(offre);
            }
            //objSingleton.Close();
            return Liste;
        }

        public List<Offre> GetOffresByContrat(string idTypeContrat)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            //objSingleton.Open();
            objSelectCommand.CommandText = "dbo.GetOffresByContrat";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_TYPE_CONTRAT", idTypeContrat);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                offre.Region.NomRegion = row["NOM_REGION"].ToString();
                offre.TypeContrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                offre.TypePoste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                offre.Entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                Liste.Add(offre);
            }
            //objSingleton.Close();
            return Liste;
        }

        public List<Offre> GetOffresByEntreprise(string idEntreprise)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            //objSingleton.Open();
            objSelectCommand.CommandText = "dbo.GetOffresByEntreprise";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_ENTREPRISE", idEntreprise);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                offre.Region.NomRegion = row["NOM_REGION"].ToString();
                offre.TypeContrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                offre.TypePoste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                offre.Entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                Liste.Add(offre);
            }
            //objSingleton.Close();
            return Liste;
        }

        public List<Offre> GetOffresByRegion(string idRegion)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            //objSingleton.Open();
            objSelectCommand.CommandText = "dbo.GetOffresByRegion";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_REGION", idRegion);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                offre.Region.NomRegion = row["NOM_REGION"].ToString();
                offre.TypeContrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                offre.TypePoste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                offre.Entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                Liste.Add(offre);
            }
            //objSingleton.Close();
            return Liste;
        }

        public int DeleteOffre(string idOffre)
        { 
            SqlCommand objSelectCommand = new SqlCommand();
            objSingleton.Open();
            objSelectCommand.CommandText = "dbo.DeleteOffre";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_OFFRE", idOffre);
            int nbLignes = objSingleton.ExecuteNonQuery(objSelectCommand);
            objSingleton.Close();
            return nbLignes;
        }
         public List<Offre> Top10()
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSingleton.Open();
            objSelectCommand.CommandText = "dbo.Top10";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSingleton.ExecuteNonQuery(objSelectCommand);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]).ToString("dd/MM/yyyy");
                offre.LienWeb = row["LIEN_WEB"].ToString();
                offre.Region.NomRegion = row["NOM_REGION"].ToString();
                offre.TypeContrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                offre.TypePoste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                offre.Entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                Liste.Add(offre);
            }
            objSingleton.Close();
            return Liste;
        }
    }
}
