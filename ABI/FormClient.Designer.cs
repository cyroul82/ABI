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
            this.gpbClientInformation = new System.Windows.Forms.GroupBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.lblChiffreAffaire = new System.Windows.Forms.Label();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.cbxActivity = new System.Windows.Forms.ComboBox();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.txtRaisonSocial = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRaisonSocial = new System.Windows.Forms.Label();
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.gpxContact = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpbClientInformation.SuspendLayout();
            this.gpxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Controls.Add(this.btnCancel);
            this.gpbClientInformation.Controls.Add(this.btnAdd);
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
            this.gpbClientInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbClientInformation.Location = new System.Drawing.Point(0, 0);
            this.gpbClientInformation.Name = "gpbClientInformation";
            this.gpbClientInformation.Size = new System.Drawing.Size(535, 365);
            this.gpbClientInformation.TabIndex = 0;
            this.gpbClientInformation.TabStop = false;
            this.gpbClientInformation.Text = "InformationClient";
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(147, 184);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(121, 20);
            this.txtCA.TabIndex = 11;
            // 
            // lblChiffreAffaire
            // 
            this.lblChiffreAffaire.AutoSize = true;
            this.lblChiffreAffaire.Location = new System.Drawing.Point(19, 188);
            this.lblChiffreAffaire.Name = "lblChiffreAffaire";
            this.lblChiffreAffaire.Size = new System.Drawing.Size(92, 13);
            this.lblChiffreAffaire.TabIndex = 10;
            this.lblChiffreAffaire.Text = "Chiffre d\'Affaires : ";
            // 
            // cbxNature
            // 
            this.cbxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.cbxNature.Location = new System.Drawing.Point(147, 152);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(121, 21);
            this.cbxNature.TabIndex = 9;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(63, 156);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(48, 13);
            this.lblNature.TabIndex = 8;
            this.lblNature.Text = "Nature : ";
            // 
            // cbxActivity
            // 
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Location = new System.Drawing.Point(147, 120);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(121, 21);
            this.cbxActivity.TabIndex = 7;
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(9, 124);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(104, 13);
            this.lblDomaine.TabIndex = 6;
            this.lblDomaine.Text = "Domaine d\'Activité : ";
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Location = new System.Drawing.Point(147, 57);
            this.txtRaisonSocial.Name = "txtRaisonSocial";
            this.txtRaisonSocial.Size = new System.Drawing.Size(203, 20);
            this.txtRaisonSocial.TabIndex = 5;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.cbxType.Location = new System.Drawing.Point(147, 88);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(147, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(73, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type : ";
            // 
            // lblRaisonSocial
            // 
            this.lblRaisonSocial.AutoSize = true;
            this.lblRaisonSocial.Location = new System.Drawing.Point(32, 61);
            this.lblRaisonSocial.Name = "lblRaisonSocial";
            this.lblRaisonSocial.Size = new System.Drawing.Size(81, 13);
            this.lblRaisonSocial.TabIndex = 1;
            this.lblRaisonSocial.Text = "Raison Social : ";
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Location = new System.Drawing.Point(63, 30);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(78, 13);
            this.lblClientNumber.TabIndex = 0;
            this.lblClientNumber.Text = "Numéro client :";
            // 
            // gpxContact
            // 
            this.gpxContact.Controls.Add(this.dgvContact);
            this.gpxContact.Controls.Add(this.flowLayoutPanel1);
            this.gpxContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpxContact.Location = new System.Drawing.Point(0, 365);
            this.gpxContact.Name = "gpxContact";
            this.gpxContact.Size = new System.Drawing.Size(535, 225);
            this.gpxContact.TabIndex = 12;
            this.gpxContact.TabStop = false;
            this.gpxContact.Text = "Contacts";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(424, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(478, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Type,
            this.Email,
            this.tel1,
            this.tel2});
            this.dgvContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContact.Location = new System.Drawing.Point(3, 16);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.Size = new System.Drawing.Size(529, 177);
            this.dgvContact.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(529, 29);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // tel1
            // 
            this.tel1.HeaderText = "Téléphone 1";
            this.tel1.Name = "tel1";
            this.tel1.ReadOnly = true;
            // 
            // tel2
            // 
            this.tel2.HeaderText = "Téléphone 2";
            this.tel2.Name = "tel2";
            this.tel2.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(417, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(473, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 590);
            this.Controls.Add(this.gpbClientInformation);
            this.Controls.Add(this.gpxContact);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            this.gpxContact.ResumeLayout(false);
            this.gpxContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbClientInformation;
        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRaisonSocial;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDomaine;
        private System.Windows.Forms.TextBox txtRaisonSocial;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.Label lblChiffreAffaire;
        private System.Windows.Forms.ComboBox cbxNature;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.ComboBox cbxActivity;
        private System.Windows.Forms.GroupBox gpxContact;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}