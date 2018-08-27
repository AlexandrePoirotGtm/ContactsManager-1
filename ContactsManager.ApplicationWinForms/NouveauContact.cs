using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsManager.Business;
using ContactsManager.DAL;

namespace ContactsManager.ApplicationWinForms
{
    public partial class NouveauContact : Form
    {
        private readonly ServiceContact serviceContact;

        public NouveauContact(ServiceContact serviceContact)
        {
            InitializeComponent();
            this.serviceContact = serviceContact;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boutonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            bool saisieValide = true;

            if (string.IsNullOrEmpty(texteNom.Text))
            {
                texteNom.BackColor = Color.Red;
                saisieValide = false;
            }
            else
            {
                texteNom.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textePrenom.Text))
            {
                textePrenom.BackColor = Color.Red;
                saisieValide = false;
            }
            else
            {
                textePrenom.BackColor = Color.White;
            }

            if (!saisieValide)
            {
                return;
            }

            var contact = new Contact();
            contact.Nom = texteNom.Text;
            contact.Prenom = textePrenom.Text;
            contact.Email = texteEmail.Text;
            contact.Telephone = texteTelephone.Text;
            contact.DateNaissance = pickerDateNaissance.Value;

            this.serviceContact.CreerContact(contact);

            this.Close();
        }
    }
}
