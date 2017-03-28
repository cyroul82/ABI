namespace ABI
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Document");
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.lblRaisonSocial = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtRaisonSocial = new System.Windows.Forms.TextBox();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.cbxActivity = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.lblChiffreAffaire = new System.Windows.Forms.Label();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gpbClientInformation = new System.Windows.Forms.GroupBox();
            this.btnAllDocument = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblContacts = new System.Windows.Forms.Label();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipAfficheTousDocuments = new System.Windows.Forms.ToolTip(this.components);
            this.gpbClientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Location = new System.Drawing.Point(11, 30);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(78, 13);
            this.lblClientNumber.TabIndex = 0;
            this.lblClientNumber.Text = "Numéro client :";
            // 
            // lblRaisonSocial
            // 
            this.lblRaisonSocial.AutoSize = true;
            this.lblRaisonSocial.Location = new System.Drawing.Point(12, 61);
            this.lblRaisonSocial.Name = "lblRaisonSocial";
            this.lblRaisonSocial.Size = new System.Drawing.Size(81, 13);
            this.lblRaisonSocial.TabIndex = 1;
            this.lblRaisonSocial.Text = "Raison Social : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(284, 96);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type : ";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(138, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.cbxType.Location = new System.Drawing.Point(345, 92);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 4;
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Location = new System.Drawing.Point(138, 57);
            this.txtRaisonSocial.Name = "txtRaisonSocial";
            this.txtRaisonSocial.Size = new System.Drawing.Size(328, 20);
            this.txtRaisonSocial.TabIndex = 5;
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(11, 96);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(104, 13);
            this.lblDomaine.TabIndex = 6;
            this.lblDomaine.Text = "Domaine d\'Activité : ";
            // 
            // cbxActivity
            // 
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Location = new System.Drawing.Point(137, 92);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(121, 21);
            this.cbxActivity.TabIndex = 7;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(12, 132);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(48, 13);
            this.lblNature.TabIndex = 8;
            this.lblNature.Text = "Nature : ";
            // 
            // cbxNature
            // 
            this.cbxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.cbxNature.Location = new System.Drawing.Point(138, 128);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(121, 21);
            this.cbxNature.TabIndex = 9;
            // 
            // lblChiffreAffaire
            // 
            this.lblChiffreAffaire.AutoSize = true;
            this.lblChiffreAffaire.Location = new System.Drawing.Point(12, 171);
            this.lblChiffreAffaire.Name = "lblChiffreAffaire";
            this.lblChiffreAffaire.Size = new System.Drawing.Size(92, 13);
            this.lblChiffreAffaire.TabIndex = 10;
            this.lblChiffreAffaire.Text = "Chiffre d\'Affaires : ";
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(137, 167);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(121, 20);
            this.txtCA.TabIndex = 11;
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(284, 132);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(54, 13);
            this.lblEffectif.TabIndex = 14;
            this.lblEffectif.Text = "Effectifs : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 15;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(12, 305);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(82, 13);
            this.lblCommentaire.TabIndex = 16;
            this.lblCommentaire.Text = "Commentaires : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 321);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 105);
            this.textBox2.TabIndex = 17;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Controls.Add(this.btnAllDocument);
            this.gpbClientInformation.Controls.Add(this.button1);
            this.gpbClientInformation.Controls.Add(this.button2);
            this.gpbClientInformation.Controls.Add(this.treeView1);
            this.gpbClientInformation.Controls.Add(this.btnEditContact);
            this.gpbClientInformation.Controls.Add(this.textBox3);
            this.gpbClientInformation.Controls.Add(this.lblTown);
            this.gpbClientInformation.Controls.Add(this.txtCodePostal);
            this.gpbClientInformation.Controls.Add(this.lblCodePostal);
            this.gpbClientInformation.Controls.Add(this.txtAddress);
            this.gpbClientInformation.Controls.Add(this.lblAddress);
            this.gpbClientInformation.Controls.Add(this.btnDeleteContact);
            this.gpbClientInformation.Controls.Add(this.btnAddContact);
            this.gpbClientInformation.Controls.Add(this.lblContacts);
            this.gpbClientInformation.Controls.Add(this.dgvContact);
            this.gpbClientInformation.Controls.Add(this.textBox2);
            this.gpbClientInformation.Controls.Add(this.lblCommentaire);
            this.gpbClientInformation.Controls.Add(this.textBox1);
            this.gpbClientInformation.Controls.Add(this.lblEffectif);
            this.gpbClientInformation.Controls.Add(this.txtCA);
            this.gpbClientInformation.Controls.Add(this.lblChiffreAffaire);
            this.gpbClientInformation.Controls.Add(this.cbxNature);
            this.gpbClientInformation.Controls.Add(this.lblNature);
            this.gpbClientInformation.Controls.Add(this.cbxActivity);
            this.gpbClientInformation.Controls.Add(this.lblDomaine);
            this.gpbClientInformation.Controls.Add(this.txtRaisonSocial);
            this.gpbClientInformation.Controls.Add(this.cbxType);
            this.gpbClientInformation.Controls.Add(this.txtNumero);
            this.gpbClientInformation.Controls.Add(this.lblType);
            this.gpbClientInformation.Controls.Add(this.lblRaisonSocial);
            this.gpbClientInformation.Controls.Add(this.lblClientNumber);
            this.gpbClientInformation.Location = new System.Drawing.Point(20, 20);
            this.gpbClientInformation.Name = "gpbClientInformation";
            this.gpbClientInformation.Size = new System.Drawing.Size(694, 654);
            this.gpbClientInformation.TabIndex = 0;
            this.gpbClientInformation.TabStop = false;
            this.gpbClientInformation.Text = "Information Société";
            // 
            // btnAllDocument
            // 
            this.btnAllDocument.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllDocument.AutoSize = true;
            this.btnAllDocument.Location = new System.Drawing.Point(17, 616);
            this.btnAllDocument.Name = "btnAllDocument";
            this.btnAllDocument.Size = new System.Drawing.Size(48, 23);
            this.btnAllDocument.TabIndex = 32;
            this.btnAllDocument.Text = "*";
            this.btnAllDocument.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(639, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(585, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(481, 19);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nDocument";
            treeNode1.Text = "Document";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(206, 591);
            this.treeView1.TabIndex = 29;
            // 
            // btnEditContact
            // 
            this.btnEditContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditContact.AutoSize = true;
            this.btnEditContact.Location = new System.Drawing.Point(318, 616);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(48, 23);
            this.btnEditContact.TabIndex = 28;
            this.btnEditContact.Text = "!";
            this.btnEditContact.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(344, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 27;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(284, 244);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(35, 13);
            this.lblTown.TabIndex = 26;
            this.lblTown.Text = "Ville : ";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(138, 237);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(94, 20);
            this.txtCodePostal.TabIndex = 25;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(11, 240);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(73, 13);
            this.lblCodePostal.TabIndex = 24;
            this.lblCodePostal.Text = "Code Postal : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(137, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 207);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 13);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Adresse : ";
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteContact.AutoSize = true;
            this.btnDeleteContact.Location = new System.Drawing.Point(426, 616);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(48, 23);
            this.btnDeleteContact.TabIndex = 20;
            this.btnDeleteContact.Text = "-";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddContact.AutoSize = true;
            this.btnAddContact.Location = new System.Drawing.Point(372, 616);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(48, 23);
            this.btnAddContact.TabIndex = 21;
            this.btnAddContact.Text = "+";
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(13, 451);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(87, 13);
            this.lblContacts.TabIndex = 19;
            this.lblContacts.Text = "Contacts FormClient : ";
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Type,
            this.Email,
            this.tel});
            this.dgvContact.Location = new System.Drawing.Point(16, 467);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.Size = new System.Drawing.Size(458, 143);
            this.dgvContact.TabIndex = 18;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Téléphone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // toolTipAfficheTousDocuments
            // 
            this.toolTipAfficheTousDocuments.Tag = "Afficher tous les documents";
            this.toolTipAfficheTousDocuments.ToolTipTitle = "Afficher tous les documents";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 696);
            this.Controls.Add(this.gpbClientInformation);
            this.MaximumSize = new System.Drawing.Size(746, 765);
            this.Name = "FormClient";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FormClient";
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.Label lblRaisonSocial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDomaine;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblChiffreAffaire;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.GroupBox gpbClientInformation;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAllDocument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTipAfficheTousDocuments;
        protected System.Windows.Forms.TextBox txtNumero;
        protected System.Windows.Forms.ComboBox cbxType;
        protected System.Windows.Forms.TextBox txtRaisonSocial;
        protected System.Windows.Forms.ComboBox cbxActivity;
        protected System.Windows.Forms.ComboBox cbxNature;
        protected System.Windows.Forms.TextBox txtCA;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.TextBox txtAddress;
        protected System.Windows.Forms.TextBox textBox3;
        protected System.Windows.Forms.TextBox txtCodePostal;
    }
}