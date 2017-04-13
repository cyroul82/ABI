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
    public delegate void ClientHandler(ClientDB client);

    public partial class frmDspClient : ABI.FormClient
    {
        private MyDataTable table;
        private MyDataView dataView;
        private ContactDB contact;
        public ClientHandler UpdatingClient;
        public ClientHandler DeletingClient;

        public Boolean IsModifed { get; private set; } = false;
        public frmDspClient(ClientDB client): base(client)
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
            grdContact.Columns[Tools.IDCLIENT].Visible = false;
            grdContact.Columns[Tools.IDCONTACT].Visible = false;

            foreach(ContactDB contact in client.ContactDB)
            {
                dataView.AddContact(contact);
            }
        }

        private void fillUpForm()
        {
            txtIdClient.Text = client.idClient.ToString();
            txtRaisonSocial.Text = client.raisonSocial;
            txtEffectif.Text = client.effectifs.ToString();
            txtCA.Text = client.ca.ToString();
            txtTelephone.Text = client.telephone;
            mTxtCodePostal.Text = client.codePostal;
            txtVille.Text = client.ville;
            txtRue.Text = client.rue;
            txtComment.Text = client.comment;
            cbxActivite.SelectedItem = client.activite;
            cbxNature.SelectedItem = client.nature;
            cbxType.SelectedItem = client.type;
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if(btnModifierClient.Text == Tools.MODIFIER)
            {
                enableClient();
            }
            else
            {
                if (updateClient(client.idClient))
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
            cbxActivite.Enabled = true;
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
            cbxActivite.Enabled = false;
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
            DialogResult result = MessageBox.Show("Voulez-vous supprimer ce client ?", "Suppression de Client", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeletingClient?.Invoke(client);
                Close();
            }
            else if (result == DialogResult.No)
            {
                Close();
            }
        }


        //Contact
        private void grdContact_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in grdContact.SelectedRows)
            {
                if(row != null)
                {
                    Int32 id = (Int32)row.Cells[0].Value;
                    foreach(ContactDB c in client.ContactDB)
                    {
                        if(c.idContact == id)
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
        private void savingContact(ContactDB contact)
        {
            this.contact = contact;
            dataView.AddContact(contact);
            client.ContactDB.Add(contact);
            grdContact.Rows[grdContact.Rows.Count - 1].Selected = true;
           
        }
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            if (contact != null)
            {
                if (MessageBox.Show("Voulez-vous supprimer le contact " + contact.nom, "Supprimer un contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Delete from the DB
                    Data.db.ContactDB.Remove(contact);
                    Data.db.SaveChanges();
                    
                    //Delete from the datatable
                    for (Int32 i = 0; i < table.Rows.Count; i++)
                    {
                        Int32 idContact = (Int32)table.Rows[i][0];
                        if (contact != null)
                        {
                            if (idContact == contact.idContact)
                            {
                                table.Rows[i].Delete();
                                if (table.Rows.Count > 0) {
                                    //grdContact.Rows.
                                }
                            }
                        }
                    }
                }
                contact = null;
            }
        }
        private void btnModifierContact_Click(object sender, EventArgs e)
        {
            if(contact != null) { 
                frmDspContact dspContact = new frmDspContact(ref contact);
                dspContact.updatingContact += new ContactHandler(this.UpdatingContact);
                dspContact.ShowDialog();
            }
        }

        private void UpdatingContact(ContactDB contact)
        {
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idContact = (Int32)table.Rows[i][0];
                if (contact != null)
                {
                    if (idContact == contact.idContact)
                    {
                        table.Rows[i][Tools.NOM] = contact.nom;
                        table.Rows[i][Tools.FONCTION] = contact.fonction;
                        table.Rows[i][Tools.EMAIL] = contact.email;
                        table.Rows[i][Tools.TELEPHONE] = contact.telephone;
                        Data.db.SaveChanges();
                    }
                }
            }
        }

        private void txtSearchContact_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearchContact.Text != String.Empty)
            {
               dataView.RowFilter = "Nom like '%" + txtSearchContact.Text + "%'";
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
            column.DataType = typeof(System.Int32);
            column.ColumnName = Tools.IDCONTACT;
            column.ReadOnly = true;
            column.AutoIncrement = true;
            column.Unique = true;
            Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = Tools.IDCLIENT;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column RAISON SOCIALE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.NOM;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column FONCTION
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.FONCTION;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column EMAIL
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.EMAIL;
            column.Unique = false;
            column.AutoIncrement = false;
            Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.TELEPHONE;
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

        public void AddContact(ContactDB contact)
        {
            try
            {
                DataRowView newRow = AddNew();
                newRow[Tools.IDCLIENT] = contact.idClient;
                newRow[Tools.IDCONTACT] = contact.idContact;
                newRow[Tools.NOM] = contact.nom;
                newRow[Tools.FONCTION] = contact.fonction;
                newRow[Tools.EMAIL] = contact.email;
                newRow[Tools.TELEPHONE] = contact.telephone;
                newRow.EndEdit();
            }
            catch (ConstraintException e)
            {
                MessageBox.Show("ConstraintException : " + e.Message);
            }
        }

    }
}
