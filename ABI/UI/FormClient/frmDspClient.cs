using ABI.ClasseMetier;
using ABI.UI.FormClient.FormContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public delegate void ClientHandler(Client client);

    public partial class frmDspClient : ABI.FormClient
    {
        private MyDataTable table;
        private MyDataView dataView;
        private Contact contact;
        public ClientHandler UpdatingClient;
        public ClientHandler DeletingClient;

        public Boolean IsModifed { get; private set; } = false;
        public frmDspClient(Client client): base(client)
        {
            InitializeComponent();
        }

        public void btnFermerClient_Click(object sender, EventArgs e)
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
            if(btnModifierClient.Text == Tools.MODIFIER)
            {
                enableClient();
            }
            else
            {
                if (updateClient(client.IdClient))
                {
                    UpdatingClient?.Invoke(client);
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
            btnModifierClient.Text = Tools.ENREGISTRER;
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
            btnModifierClient.Text = Tools.MODIFIER;
            btnAnnulerModifClient.Visible = false;
            IsModifed = false;
        }

        private void btnAnnulerModificationClient_Click(object sender, EventArgs e)
        {
            fillUpForm();
            disableClient();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
//            DeletingClient?.Invoke(client);
        }


        //Contact
        private void grdContact_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in grdContact.SelectedRows)
            {
                if(row != null)
                {
                    Int32 id = (Int32)row.Cells[0].Value;
                    foreach(Contact c in client.ListContacts)
                    {
                        if(c.IdContact == id)
                        {
                            contact = c;
                        }
                    }
                }
            }
        }
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmNewContact fnc = new frmNewContact(client);
            fnc.saveNewContact += new ContactHandler(this.savingContact);
            fnc.ShowDialog();
        }
        private void savingContact(Contact contact)
        {
            this.contact = contact;
            dataView.AddContact(contact);
            client.ListContacts.Add(contact);
        }
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idContact = (Int32)table.Rows[i][0];
                if (contact != null)
                {
                    if (idContact == contact.IdContact)
                    {
                        table.Rows[i].Delete();
                    }
                }
            }
           // dataView.Removecontact(contact);
            client.ListContacts.Remove(contact);
            contact = null;
        }
        private void btnModifierContact_Click(object sender, EventArgs e)
        {
            if(contact != null) { 
                frmDspContact dspContact = new frmDspContact(ref contact);
                dspContact.updatingContact += new ContactHandler(this.UpdatingContact);
                dspContact.ShowDialog();
            }
        }

        private void UpdatingContact(Contact contact)
        {
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idContact = (Int32)table.Rows[i][0];
                if (contact != null)
                {
                    if (idContact == contact.IdContact)
                    {
                        table.Rows[i][Tools.NOM] = contact.Nom;
                        table.Rows[i][Tools.FONCTION] = contact.Fonction;
                        table.Rows[i][Tools.EMAIL] = contact.Email;
                        table.Rows[i][Tools.TELEPHONE] = contact.Telephone;
                    }
                }
            }
        }
    }

    class MyDataTable : DataTable
    {
        private DataColumn column;
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
            //Column IDCLIENT
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = Tools.IDCLIENT;
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            column = new DataColumn();
            //Column IDCONTACT Unique and ReadOnly
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = Tools.IDCONTACT;
            column.ReadOnly = true;
            column.AutoIncrement = true;
            column.Unique = true;
            Columns.Add(column);

            //Column RAISON SOCIALE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.NOM;
            column.ReadOnly = false;
            column.Unique = true;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column FONCTION
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.FONCTION;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column EMAIL
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.EMAIL;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.TELEPHONE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);
        }
    }

    class MyDataView : DataView
    {
        public MyDataView(DataTable table) : base(table)
        {

        }

        public void AddContact(Contact contact)
        {
            try
            {
                DataRowView newRow = AddNew();
                newRow[Tools.IDCLIENT] = contact.IdClient;
                newRow[Tools.IDCONTACT] = contact.IdContact;
                newRow[Tools.NOM] = contact.Nom;
                newRow[Tools.FONCTION] = contact.Fonction;
                newRow[Tools.EMAIL] = contact.Email;
                newRow[Tools.TELEPHONE] = contact.Telephone;
                newRow.EndEdit();
            }
            catch (ConstraintException e)
            {
                MessageBox.Show("ConstraintException : " + e.Message);
            }
        }


        


    }
}
