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
            this.lblDomaine = new System.Windows.Forms.Label();
            this.txtRaisonSocial = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRaisonSocial = new System.Windows.Forms.Label();
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.cbxActivity = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.lblChiffreAffaire = new System.Windows.Forms.Label();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.gpbClientInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClientInformation
            // 
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
            this.gpbClientInformation.Size = new System.Drawing.Size(469, 390);
            this.gpbClientInformation.TabIndex = 0;
            this.gpbClientInformation.TabStop = false;
            this.gpbClientInformation.Text = "InformationClient";
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(9, 122);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(104, 13);
            this.lblDomaine.TabIndex = 6;
            this.lblDomaine.Text = "Domaine d\'Activité : ";
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Location = new System.Drawing.Point(130, 56);
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
            this.cbxType.Location = new System.Drawing.Point(130, 85);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(130, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(73, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type : ";
            // 
            // lblRaisonSocial
            // 
            this.lblRaisonSocial.AutoSize = true;
            this.lblRaisonSocial.Location = new System.Drawing.Point(32, 57);
            this.lblRaisonSocial.Name = "lblRaisonSocial";
            this.lblRaisonSocial.Size = new System.Drawing.Size(81, 13);
            this.lblRaisonSocial.TabIndex = 1;
            this.lblRaisonSocial.Text = "Raison Social : ";
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Location = new System.Drawing.Point(63, 26);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(50, 13);
            this.lblClientNumber.TabIndex = 0;
            this.lblClientNumber.Text = "Numéro :";
            // 
            // cbxActivity
            // 
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Location = new System.Drawing.Point(130, 118);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(121, 21);
            this.cbxActivity.TabIndex = 7;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(63, 158);
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
            this.cbxNature.Location = new System.Drawing.Point(130, 155);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(121, 21);
            this.cbxNature.TabIndex = 9;
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
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(130, 188);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(121, 20);
            this.txtCA.TabIndex = 11;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 390);
            this.Controls.Add(this.gpbClientInformation);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
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
    }
}