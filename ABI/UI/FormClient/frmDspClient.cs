using ABI.ClasseMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public delegate void UpdatedClientHandler(Client client);
    public partial class frmDspClient : ABI.FormClient
    {
        private MyDataTable table;
        private MyDataView dataView;
        private Contact contact;
        public event UpdatedClientHandler Updated;
        private const String MODIFIER = "Modifier";
        private const String ENREGISTRER = "Enregistrer";

        public Boolean IsModifed { get; private set; } = false;
        public frmDspClient(Client client): base(client)
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewContact fnc = new frmNewContact(client);
            fnc.saveNewContact += new SaveNewContact(this.saveContact);
            fnc.ShowDialog();
        }

        private void saveContact(Contact contact)
        {
            dataView.AddContact(contact);
            client.ListContacts.Add(contact);
        }

        public void btnFermer_Click(object sender, EventArgs e)
        {
            if (IsModifed)
            {
                DialogResult result = MessageBox.Show("Voulez-vous sauvegarder les modifications ?", "Modifications", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnModifierClient_Click(sender, e);
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            } 
            else
            {
                Close();
            }
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            fillUpForm();

            table = new MyDataTable("ContactTable");
            grdContact.DataSource = table;
            dataView = new MyDataView(table);

            foreach(Contact contact in client.ListContacts)
            {
                dataView.AddContact(contact);
            }
        }

        private void fillUpForm()
        {
            txtNumero.Text = client.IdClient.ToString();
            txtRaisonSocial.Text = client.RaisonSocial;
            txtEffectif.Text = client.Effectifs.ToString();
            txtCA.Text = client.ChiffreAffaires.ToString();
            txtTelephone.Text = client.Telephone;
            mTxtCodePostal.Text = client.Adresse.CodePostal;
            txtVille.Text = client.Adresse.Ville;
            txtRue.Text = client.Adresse.Rue;
            txtComment.Text = client.Comment;
            cbxActivity.SelectedItem = client.Activite;
            cbxNature.SelectedItem = client.Nature;
            cbxType.SelectedItem = client.TypeSociete;
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if(btnModifierClient.Text == MODIFIER)
            {
                enableClient();
            }
            else
            {
                if (updateClient(client.IdClient))
                {
                    Updated?.Invoke(client);
                    disableClient();
                }
            }
        }

        private void enableClient()
        {
            mTxtCodePostal.Enabled = true;
            txtCA.Enabled = true;
            txtComment.Enabled = true;
            txtComment.Enabled = true;
            txtEffectif.Enabled = true;
            txtRaisonSocial.Enabled = true;
            txtRue.Enabled = true;
            txtTelephone.Enabled = true;
            txtVille.Enabled = true;
            cbxActivity.Enabled = true;
            cbxNature.Enabled = true;
            cbxType.Enabled = true;
            btnModifierClient.Text = ENREGISTRER;
            btnAnnulerModifClient.Visible = true;
            IsModifed = true;
        }

        private void disableClient()
        {
            mTxtCodePostal.Enabled = false;
            txtCA.Enabled = false;
            txtComment.Enabled = false;
            txtComment.Enabled = false;
            txtEffectif.Enabled = false;
            txtRaisonSocial.Enabled = false;
            txtRue.Enabled = false;
            txtTelephone.Enabled = false;
            txtVille.Enabled = false;
            cbxActivity.Enabled = false;
            cbxNature.Enabled = false;
            cbxType.Enabled = false;
            btnModifierClient.Text = MODIFIER;
            btnAnnulerModifClient.Visible = false;
            IsModifed = false;
        }

        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            fillUpForm();
            disableClient();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dataView.Removecontact(contact);
            client.ListContacts.Remove(contact);
        }

        private void grdContact_SelectionChanged(object sender, EventArgs e)
        {

            Int32 id = (Int32)grdContact[0, grdContact.CurrentRow.Index].Value;
            for (Int32 i = 0; i < client.ListContacts.Count; i++)
            {
                Contact c = client.ListContacts[i];
                if (contact.IdContact == id)
                {
                    contact = c;
                }
            }
        }
    }

    class MyDataTable : DataTable
    {
        private DataColumn column;
        private const String IDCLIENT = "idClient";
        private const String NOM = "Nom";
        private const String NOM_CAPTION = "Nom";
        private const String FONCTION = "Fonction";
        private const String EMAIL = "Email";
        private const String TELEPHONE = "Téléphone";
        public MyDataTable(string tableName) : base(tableName)
        {
            buildTableColumn();
        }

        /// <summary>
        /// Build the Table Column with DataColumn
        /// </summary>
        private void buildTableColumn()
        {
            column = new DataColumn();
            //Column IDCLIENT Unique and ReadOnly
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = IDCLIENT;
            column.ReadOnly = true;
            column.Unique = true;
            Columns.Add(column);

            //Column RAISON SOCIALE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = NOM;
            column.Caption = NOM_CAPTION;
            column.ReadOnly = false;
            column.Unique = true;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column FONCTION
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = FONCTION;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column EMAIL
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = EMAIL;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = TELEPHONE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);
        }
    }

    class MyDataView : DataView
    {
        private const String IDCLIENT = "idClient";
        private const String NOM = "Nom";
        private const String FONCTION = "Fonction";
        private const String EMAIL = "Email";
        private const String TELEPHONE = "Téléphone";
        public MyDataView(DataTable table) : base(table)
        {

        }

        public void AddContact(Contact contact)
        {
            try
            {
                DataRowView newRow = AddNew();
                newRow[IDCLIENT] = contact.IdContact;
                newRow[NOM] = contact.Nom;
                newRow[FONCTION] = contact.Fonction;
                newRow[EMAIL] = contact.Email;
                newRow[TELEPHONE] = contact.Telephone;
                newRow.EndEdit();
            }
            catch (ConstraintException e)
            {
                MessageBox.Show("ConstraintException : " + e.Message);
            }
        }

        public void Removecontact(Contact contact)
        {
            Int32 indexRow = Find(contact);
            Delete(indexRow);
            Console.WriteLine("line contact if found : " + indexRow);
        }

        


    }
}
