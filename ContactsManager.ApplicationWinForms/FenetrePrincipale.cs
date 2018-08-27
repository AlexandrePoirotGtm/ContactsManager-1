using System;
using System.Windows.Forms;
using ContactsManager.Business;

namespace ContactsManager.ApplicationWinForms
{
    public partial class FenetrePrincipale : Form
    {
        private ServiceContact serviceContact = new ServiceContact();

        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            AfficherContacts();
        }

        private void boutonNouveau_Click(object sender, EventArgs e)
        {
            var nouveauContact = new NouveauContact(this.serviceContact);
            nouveauContact.ShowDialog();
            AfficherContacts();
        }

        private void AfficherContacts()
        {
            var contacts = this.serviceContact.GetContacts();
            grilleContacts.DataSource = contacts;
        }
    }
}
