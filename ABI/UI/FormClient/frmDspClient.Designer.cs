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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gpxContact = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbClientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpxContact.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxType
            // 
            this.cbxType.Enabled = false;
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Enabled = false;
            // 
            // cbxActivity
            // 
            this.cbxActivity.Enabled = false;
            // 
            // cbxNature
            // 
            this.cbxNature.Enabled = false;
            // 
            // txtCA
            // 
            this.txtCA.Enabled = false;
            // 
            // txtEffectif
            // 
            this.txtEffectif.Enabled = false;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            // 
            // txtRue
            // 
            this.txtRue.Enabled = false;
            // 
            // txtVille
            // 
            this.txtVille.Enabled = false;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Controls.Add(this.btnModifier);
            this.gpbClientInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbClientInformation.Size = new System.Drawing.Size(490, 484);
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
            this.gpbClientInformation.Controls.SetChildIndex(this.mTxtCodePostal, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtVille, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.btnModifier, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtTelephone, 0);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Enabled = false;
            // 
            // mTxtCodePostal
            // 
            this.mTxtCodePostal.Enabled = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnregistrer);
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(434, 6);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(515, 6);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(399, 432);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // gpxContact
            // 
            this.gpxContact.Controls.Add(this.panel2);
            this.gpxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxContact.Location = new System.Drawing.Point(510, 20);
            this.gpxContact.Name = "gpxContact";
            this.gpxContact.Size = new System.Drawing.Size(457, 484);
            this.gpxContact.TabIndex = 2;
            this.gpxContact.TabStop = false;
            this.gpxContact.Text = "Contact";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 465);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Controls.Add(this.btnAfficher);
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 436);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchClient.Location = new System.Drawing.Point(373, 3);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 5;
            this.btnSearchClient.Text = "Ok";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(197, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(170, 20);
            this.txtSearchClient.TabIndex = 4;
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(122, 8);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(69, 13);
            this.lblSearchClient.TabIndex = 3;
            this.lblSearchClient.Text = "Recherche : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmDspClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(987, 563);
            this.Controls.Add(this.gpxContact);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDspClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gpbClientInformation, 0);
            this.Controls.SetChildIndex(this.gpxContact, 0);
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gpxContact.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnEnregistrer;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
