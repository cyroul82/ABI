namespace ABI.UI.FormClient.FormContact
{
    partial class frmDspContact
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
            this.btnEnregistrerContact = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gpxContactDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrerContact
            // 
            this.btnEnregistrerContact.Location = new System.Drawing.Point(71, 170);
            this.btnEnregistrerContact.Name = "btnEnregistrerContact";
            this.btnEnregistrerContact.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerContact.TabIndex = 1;
            this.btnEnregistrerContact.Text = "Enregistrer";
            this.btnEnregistrerContact.UseVisualStyleBackColor = true;
            this.btnEnregistrerContact.Click += new System.EventHandler(this.btnEnregistrerContact_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(163, 170);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmDspContact
            // 
            this.AcceptButton = this.btnEnregistrerContact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(316, 199);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrerContact);
            this.Name = "frmDspContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDspContact_Load);
            this.Controls.SetChildIndex(this.gpxContactDetail, 0);
            this.Controls.SetChildIndex(this.btnEnregistrerContact, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.gpxContactDetail.ResumeLayout(false);
            this.gpxContactDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrerContact;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
