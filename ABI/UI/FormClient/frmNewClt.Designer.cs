namespace ABI
{
    partial class frmNewClt
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
            if (disposing && (components != null))
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
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnAnnulerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).BeginInit();
            this.gpbClientInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Size = new System.Drawing.Size(493, 448);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnAnnulerClient);
            this.panel1.Controls.Add(this.btnAjouterClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(177, 17);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(142, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Enregistrer et Visualiser";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnAnnulerClient
            // 
            this.btnAnnulerClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulerClient.Location = new System.Drawing.Point(328, 17);
            this.btnAnnulerClient.Name = "btnAnnulerClient";
            this.btnAnnulerClient.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerClient.TabIndex = 1;
            this.btnAnnulerClient.Text = "Annuler";
            this.btnAnnulerClient.UseVisualStyleBackColor = true;
            this.btnAnnulerClient.Click += new System.EventHandler(this.btnAnnulerClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(93, 17);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Enregistrer";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // frmNewClt
            // 
            this.AcceptButton = this.btnAjouterClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnAnnulerClient;
            this.ClientSize = new System.Drawing.Size(533, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewClt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gpbClientInformation, 0);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnnulerClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnPreview;
    }
}
