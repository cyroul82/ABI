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
            this.btnSavePreview = new System.Windows.Forms.Button();
            this.btnCancelClient = new System.Windows.Forms.Button();
            this.btnSaveClient = new System.Windows.Forms.Button();
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
            // mTxtCodePostal
            // 
            this.mTxtCodePostal.Location = new System.Drawing.Point(138, 263);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(344, 263);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(137, 225);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(14, 311);
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(345, 118);
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(137, 157);
            // 
            // cbxNature
            // 
            this.cbxNature.Location = new System.Drawing.Point(138, 118);
            // 
            // cbxActivite
            // 
            this.cbxActivite.Location = new System.Drawing.Point(137, 82);
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Location = new System.Drawing.Point(138, 47);
            // 
            // cbxType
            // 
            this.cbxType.Location = new System.Drawing.Point(345, 82);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(353, 422);
            this.txtIdClient.Visible = false;
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.Location = new System.Drawing.Point(226, 426);
            this.lblClientNumber.Visible = false;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Size = new System.Drawing.Size(493, 448);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(138, 192);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(13, 195);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Location = new System.Drawing.Point(11, 262);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(11, 229);
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.Location = new System.Drawing.Point(12, 295);
            // 
            // lblChiffreAffaire
            // 
            this.lblChiffreAffaire.Location = new System.Drawing.Point(12, 161);
            // 
            // lblNature
            // 
            this.lblNature.Location = new System.Drawing.Point(12, 122);
            // 
            // lblDomaine
            // 
            this.lblDomaine.Location = new System.Drawing.Point(11, 86);
            // 
            // lblRaisonSocial
            // 
            this.lblRaisonSocial.Location = new System.Drawing.Point(12, 51);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSavePreview);
            this.panel1.Controls.Add(this.btnCancelClient);
            this.panel1.Controls.Add(this.btnSaveClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnSavePreview
            // 
            this.btnSavePreview.Location = new System.Drawing.Point(177, 17);
            this.btnSavePreview.Name = "btnSavePreview";
            this.btnSavePreview.Size = new System.Drawing.Size(142, 23);
            this.btnSavePreview.TabIndex = 2;
            this.btnSavePreview.Text = "Enregistrer et Visualiser";
            this.btnSavePreview.UseVisualStyleBackColor = true;
            this.btnSavePreview.Click += new System.EventHandler(this.btnSavePreview_Click);
            // 
            // btnCancelClient
            // 
            this.btnCancelClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelClient.Location = new System.Drawing.Point(328, 17);
            this.btnCancelClient.Name = "btnCancelClient";
            this.btnCancelClient.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClient.TabIndex = 1;
            this.btnCancelClient.Text = "Annuler";
            this.btnCancelClient.UseVisualStyleBackColor = true;
            this.btnCancelClient.Click += new System.EventHandler(this.btnCancelClient_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Location = new System.Drawing.Point(93, 17);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClient.TabIndex = 0;
            this.btnSaveClient.Text = "Enregistrer";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // frmNewClt
            // 
            this.AcceptButton = this.btnSaveClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnCancelClient;
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
        private System.Windows.Forms.Button btnCancelClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnSavePreview;
    }
}
