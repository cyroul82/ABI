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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gpbClientInformation.SuspendLayout();
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
            this.gpbClientInformation.Controls.Add(this.textBox3);
            this.gpbClientInformation.Controls.Add(this.lblTown);
            this.gpbClientInformation.Controls.Add(this.txtCodePostal);
            this.gpbClientInformation.Controls.Add(this.lblCodePostal);
            this.gpbClientInformation.Controls.Add(this.txtAddress);
            this.gpbClientInformation.Controls.Add(this.lblAddress);
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
            this.gpbClientInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbClientInformation.Location = new System.Drawing.Point(20, 20);
            this.gpbClientInformation.Name = "gpbClientInformation";
            this.gpbClientInformation.Size = new System.Drawing.Size(488, 445);
            this.gpbClientInformation.TabIndex = 0;
            this.gpbClientInformation.TabStop = false;
            this.gpbClientInformation.Text = "Information Société";
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
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 485);
            this.Controls.Add(this.gpbClientInformation);
            this.Name = "FormClient";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Client";
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
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
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCodePostal;
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
        protected System.Windows.Forms.GroupBox gpbClientInformation;
    }
}