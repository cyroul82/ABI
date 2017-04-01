namespace ABI
{
	partial class frmDspClient
	{
	        /// <summary>
	        /// Variable nécessaire au concepteur.
	        /// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
	        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gpxContact = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgContact = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.btnAnnulerModif = new System.Windows.Forms.Button();
            this.gpxDocument = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnAnnulerModifClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).BeginInit();
            this.gpbClientInformation.SuspendLayout();
            this.gpxContact.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTxtCodePostal
            // 
            this.mTxtCodePostal.Enabled = false;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Enabled = false;
            // 
            // txtVille
            // 
            this.txtVille.Enabled = false;
            // 
            // txtRue
            // 
            this.txtRue.Enabled = false;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Size = new System.Drawing.Size(451, 105);
            // 
            // txtEffectif
            // 
            this.txtEffectif.Enabled = false;
            // 
            // txtCA
            // 
            this.txtCA.Enabled = false;
            // 
            // cbxNature
            // 
            this.cbxNature.Enabled = false;
            // 
            // cbxActivity
            // 
            this.cbxActivity.Enabled = false;
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Enabled = false;
            // 
            // cbxType
            // 
            this.cbxType.Enabled = false;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.AutoSize = true;
            this.gpbClientInformation.Controls.Add(this.btnAnnulerModifClient);
            this.gpbClientInformation.Controls.Add(this.btnModifierClient);
            this.gpbClientInformation.Dock = System.Windows.Forms.DockStyle.None;
            this.gpbClientInformation.Location = new System.Drawing.Point(20, 22);
            this.gpbClientInformation.Size = new System.Drawing.Size(480, 449);
            this.gpbClientInformation.Controls.SetChildIndex(this.lblClientNumber, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtNumero, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.cbxType, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtRaisonSocial, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.cbxActivity, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.cbxNature, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtCA, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtEffectif, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtComment, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtRue, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtVille, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtTelephone, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.mTxtCodePostal, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.btnModifierClient, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.btnAnnulerModifClient, 0);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(20, 477);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(265, 25);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // gpxContact
            // 
            this.gpxContact.Controls.Add(this.panel2);
            this.gpxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxContact.Location = new System.Drawing.Point(0, 0);
            this.gpxContact.Name = "gpxContact";
            this.gpxContact.Padding = new System.Windows.Forms.Padding(10);
            this.gpxContact.Size = new System.Drawing.Size(437, 255);
            this.gpxContact.TabIndex = 2;
            this.gpxContact.TabStop = false;
            this.gpxContact.Text = "Contact";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgContact);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 222);
            this.panel2.TabIndex = 1;
            // 
            // dtgContact
            // 
            this.dtgContact.AllowUserToAddRows = false;
            this.dtgContact.AllowUserToDeleteRows = false;
            this.dtgContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgContact.Location = new System.Drawing.Point(112, 29);
            this.dtgContact.Name = "dtgContact";
            this.dtgContact.Size = new System.Drawing.Size(305, 193);
            this.dtgContact.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Controls.Add(this.btnAfficher);
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 193);
            this.panel3.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(21, 70);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(21, 41);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSearchClient);
            this.flowLayoutPanel1.Controls.Add(this.txtSearchClient);
            this.flowLayoutPanel1.Controls.Add(this.lblSearchClient);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchClient.Location = new System.Drawing.Point(339, 3);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 5;
            this.btnSearchClient.Text = "Ok";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(88, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(245, 20);
            this.txtSearchClient.TabIndex = 4;
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(13, 8);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(69, 13);
            this.lblSearchClient.TabIndex = 3;
            this.lblSearchClient.Text = "Recherche : ";
            // 
            // btnAnnulerModif
            // 
            this.btnAnnulerModif.Location = new System.Drawing.Point(345, 25);
            this.btnAnnulerModif.Name = "btnAnnulerModif";
            this.btnAnnulerModif.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerModif.TabIndex = 31;
            this.btnAnnulerModif.Text = "Annuler";
            this.btnAnnulerModif.UseVisualStyleBackColor = true;
            this.btnAnnulerModif.Visible = false;
            this.btnAnnulerModif.Click += new System.EventHandler(this.btnAnnulerModif_Click);
            // 
            // gpxDocument
            // 
            this.gpxDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxDocument.Location = new System.Drawing.Point(0, 0);
            this.gpxDocument.Name = "gpxDocument";
            this.gpxDocument.Size = new System.Drawing.Size(437, 253);
            this.gpxDocument.TabIndex = 3;
            this.gpxDocument.TabStop = false;
            this.gpxDocument.Text = "Document";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(519, 23);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gpxContact);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpxDocument);
            this.splitContainer1.Size = new System.Drawing.Size(437, 512);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(277, 25);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(75, 23);
            this.btnModifierClient.TabIndex = 31;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnAnnulerModifClient
            // 
            this.btnAnnulerModifClient.Location = new System.Drawing.Point(358, 25);
            this.btnAnnulerModifClient.Name = "btnAnnulerModifClient";
            this.btnAnnulerModifClient.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerModifClient.TabIndex = 32;
            this.btnAnnulerModifClient.Text = "Annuler";
            this.btnAnnulerModifClient.UseVisualStyleBackColor = true;
            this.btnAnnulerModifClient.Visible = false;
            this.btnAnnulerModifClient.Click += new System.EventHandler(this.btnAnnulerModif_Click);
            // 
            // frmDspClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(976, 600);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frmDspClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDspClient_Load);
            this.Controls.SetChildIndex(this.gpbClientInformation, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).EndInit();
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            this.gpxContact.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).EndInit();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox gpxContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.DataGridView dtgContact;
        private System.Windows.Forms.Button btnAnnulerModif;
        private System.Windows.Forms.GroupBox gpxDocument;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAnnulerModifClient;
    }
}
