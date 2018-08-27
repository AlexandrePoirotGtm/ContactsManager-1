using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.DAL
{
    public class DonneesContactBase : IDonneesContact
    {
        public void Enregistrer(Contact contact)
        {
            if (contact.Id == 0)
            {
                Ajouter(contact);
            }
            else
            {
                Modifier(contact);
            }
        }

        public IEnumerable<Contact> GetListe()
        {
            throw new NotImplementedException();
        }

        public void Supprimer(Contact contact)
        {
            throw new NotImplementedException();
        }

        private void Ajouter(Contact contact)
        {
        }

        private void Modifier(Contact contact)
        {
        }

        private SqlConnection CreerConnexion()
        {
            return new SqlConnection(
                ConfigurationManager
                .ConnectionStrings["Connexion"]
                .ConnectionString);
        }
    }
}
