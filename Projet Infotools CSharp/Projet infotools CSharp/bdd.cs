using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Projet_infotools_CSharp
{
    class bdd
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        //Initialisation des valeurs
        public static void Initialize()
        {
            server = "127.0.0.1";
            database = "bdd-infotools-csharp";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        #region Co/Deco

        //open connection to database
        private static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                Console.WriteLine("Erreur connexion BDD");
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        #region client

        public static ObservableCollection<client> SelectClient()
        {
            //Select statement
            string query = "SELECT * FROM clients";

            //Create a list to store the result
            ObservableCollection<client> dbClient = new ObservableCollection<client>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    client leClient = new client(Convert.ToInt16(dataReader["id"]), Convert.ToString(dataReader["prenomCli"]), Convert.ToString(dataReader["nomCli"]),
                        Convert.ToString(dataReader["telCli"]), Convert.ToString(dataReader["mailCli"]),
                        Convert.ToString(dataReader["adresseCli"]), Convert.ToString(dataReader["cpCli"]), Convert.ToString(dataReader["villeCli"]));
                    dbClient.Add(leClient);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbClient;
            }
            else
            {
                return dbClient;
            }
        }

        public static int InsertClient(client unCli)
        {
            //Select statement
            string query = "insert into clients values (null , '" + unCli.prenom + "','" + unCli.nom + "','" + unCli.adresse + "','" + unCli.cp + "','" + unCli.ville + "','" + unCli.telephone + "','" + 
                unCli.email + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            int id = 0;

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(id) as id from clients";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                id = Convert.ToInt32(dataReader["id"]);
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
            }
            return id;
        }
        public static void UpdateClient(client unCli)
        {
            //Update Produit
            string query = "UPDATE clients SET prenomCli='" + unCli.prenom + "', nomCli='" + unCli.nom + "', adresseCli='" + unCli.adresse + "', cpCli='" + unCli.cp + "', villeCli='" + unCli.ville +
                "', telCli='" + unCli.telephone + "', mailCli='" + unCli.email + "',updated_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=" + unCli.id;
            Console.WriteLine(query);
            //Open connection
            if (bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }

        public static void DeleteClient(int Id)
        {
            //Delete Produit
            string query = "DELETE FROM clients WHERE id=" + Id;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        #endregion

        #region produit

        public static ObservableCollection<Produit> SelectProduit()
        {
            //Select statement
            string query = "SELECT * FROM produits";

            //Create a list to store the result
            ObservableCollection<Produit> dbProduit = new ObservableCollection<Produit>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    Produit leProduit = new Produit(Convert.ToInt16(dataReader["id"]), Convert.ToString(dataReader["libProd"]), Convert.ToDecimal(dataReader["prixProd"]));
                    dbProduit.Add(leProduit);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbProduit;
            }
            else
            {
                return dbProduit;
            }
        }

        public static int InsertProduit(Produit unProd)
        {
            //Requête Insertion Produit
            string query = "INSERT INTO produits (libProd, prixProd) VALUES('" + unProd.NomProd + "'," + unProd.Prix.ToString().Replace(",", ".") + ")";
            Console.WriteLine(query);

            int id = 0;

            //open connection
            if (bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(id) as id from produits";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                id = Convert.ToInt32(dataReader["id"]);
                dataReader.Close();

                //close connection
                bdd.CloseConnection();
            }
            return id;
        }

        public static void UpdateProduit(Produit unProd)
        {
            //Update Produit
            string query = "UPDATE produits SET libProd='" + unProd.NomProd + "', prixProd='" + unProd.Prix.ToString().Replace(",",".") + "',updated_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=" + unProd.NumProd;
            Console.WriteLine(query);
            //Open connection
            if (bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }

        public static void DeleteProduit(int Id)
        {
            //Delete Produit
            string query = "DELETE FROM produits WHERE id=" + Id;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        #endregion

        #region users

        public static List<users> SearchUser(string email)
        {
            //Select statement
            string query = "SELECT * FROM admin where identifiant='" + email + "'";

            //Create a list to store the result
            List<users> dbUser = new List<users>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    users leUser = new users(Convert.ToInt16(dataReader["id"]), Convert.ToString(dataReader["identifiant"]), dataReader["mdp"].ToString());
                    dbUser.Add(leUser);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbUser;
            }
            else
            {
                return dbUser;
            }
        }

        #endregion

        #region RDV

        public static ObservableCollection<rdv> SelectRDV()
        {
            //Select statement
            string query = "SELECT * FROM rdvs r join clients c on r.idCli = c.id join commercial co on r.idCom = co.id";

            //Create a list to store the result
            ObservableCollection<rdv> dbRdv = new ObservableCollection<rdv>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    rdv leRdv = new rdv(Convert.ToInt16(dataReader["id"]), Convert.ToDateTime(dataReader["dateRdv"]), new client(Convert.ToInt32(dataReader["idCli"]), dataReader["prenomCli"].ToString(),
                        dataReader["nomCli"].ToString(), dataReader["telCli"].ToString(), dataReader["mailCli"].ToString(), dataReader["adresseCli"].ToString(), dataReader["cpCli"].ToString(), 
                        dataReader["villeCli"].ToString()), new commercial(Convert.ToInt32(dataReader["idCom"]), dataReader["prenomCom"].ToString(), dataReader["nomCom"].ToString(), 
                        dataReader["adresseCom"].ToString(), dataReader["cpCom"].ToString(), dataReader["villeCom"].ToString(), dataReader["emailCom"].ToString()));
                    dbRdv.Add(leRdv);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbRdv;
            }
            else
            {
                return dbRdv;
            }
        }

        public static int InsertRDV(rdv unRdv)
        {
            //Requête Insertion RDV
            string query = "INSERT INTO rdvs (dateRdv, idCli, idCom, created_at, updated_at) VALUES('" + unRdv.dateRDV.ToString("yyyy-MM-dd HH:mm:ss") + "'," + unRdv.cli.id + "," + unRdv.com.id + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            Console.WriteLine(query);

            int id = 0;

            //open connection
            if (bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(id) as id from rdvs";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                id = Convert.ToInt32(dataReader["id"]);
                dataReader.Close();

                //close connection
                bdd.CloseConnection();
            }
            return id;
        }

        public static void UpdateRDV(rdv unRdv)
        {
            //Update Produit
            string query = "UPDATE rdvs SET dateRdv='" + unRdv.dateRDV.ToString("yyyy-MM-dd HH:mm:ss") + "', idCli='" + unRdv.cli.id + "', idCom='" + unRdv.com.id + "',updated_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=" + unRdv.id;
            Console.WriteLine(query);
            //Open connection
            if (bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }

        public static void DeleteRDV(int Id)
        {
            //Delete Produit
            string query = "DELETE FROM rdvs WHERE id=" + Id;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        #endregion

        #region commercial

        public static ObservableCollection<commercial> SelectCommercial()
        {
            //Select statement
            string query = "SELECT * FROM commercial";

            //Create a list to store the result
            ObservableCollection<commercial> dbCom = new ObservableCollection<commercial>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    commercial leCom = new commercial(Convert.ToInt16(dataReader["id"]), Convert.ToString(dataReader["prenomCom"]), Convert.ToString(dataReader["nomCom"]),
                        Convert.ToString(dataReader["adresseCom"]), Convert.ToString(dataReader["cpCom"]), Convert.ToString(dataReader["villeCom"]), Convert.ToString(dataReader["emailCom"]));
                    dbCom.Add(leCom);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbCom;
            }
            else
            {
                return dbCom;
            }
        }

        public static int InsertCommercial(commercial unCom, string password)
        {
            //Requête Insertion Produit
            string query = "INSERT INTO commercial (nomCom, prenomCom, adresseCom, cpCom, villeCom, emailCom, created_at, updated_at, password) " +
                "VALUES('" + unCom.nom + "','" + unCom.prenom + "','" + unCom.adresse + "','" + unCom.cp + "','" + unCom.ville + "','" + unCom.email + "', '" + 
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + password + "')";
            Console.WriteLine(query);

            int id = 0;

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(id) as id from commercial";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                id = Convert.ToInt32(dataReader["id"]);
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
            }
            return id;
        }

        public static void UpdateCommercial(commercial unCom)
        {
            //Update Produit
            string query = "UPDATE commercial SET nomCom='" + unCom.nom + "', prenomCom='" + unCom.prenom + "', adresseCom='" + unCom.adresse + "', cpCom='" + unCom.cp + "', villeCom='" + unCom.ville +
                "', emailCom='" + unCom.email + "',updated_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=" + unCom.id;
            Console.WriteLine(query);
            //Open connection
            if (bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }

        public static void DeleteCom(int Id)
        {
            //Delete Produit
            string query = "DELETE FROM commercial WHERE id=" + Id;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        #endregion
    }
}
