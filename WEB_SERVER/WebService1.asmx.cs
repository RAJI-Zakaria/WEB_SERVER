using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WEB_SERVER
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        static List<Utilisateur> utilisateurs = new List<Utilisateur>();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public int ajouter(Utilisateur usr)
        {
            utilisateurs.Add(usr);
            return utilisateurs.Count()-1;
        }
        public List<Utilisateur> donner_utilisateur()
        {
            return utilisateurs;
        }
        public Utilisateur donner_User(int index)
        {
            return utilisateurs[index];
        }

        public class Utilisateur
        {
            String nom;
            String prenom;
            int Age;

        }
    }
}
