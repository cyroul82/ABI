namespace ABI
{
    partial class frmNewContact
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
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gpxContactDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxContactDetail
            // 
            this.gpxContactDetail.Size = new System.Drawing.Size(296, 183);
            // 
            // txtContactIdClient
            // 
            this.txtContactIdClient.Visible = false;
            // 
            // lblIdContact
            // 
            this.lblIdContact.Location = new System.Drawing.Point(25, 20);
            this.lblIdContact.Visible = false;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(73, 201);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Ajouter";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(164, 201);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmNewContact
            // 
            this.AcceptButton = this.btnAddContact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(316, 236);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAddContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNewContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.SetChildIndex(this.gpxContactDetail, 0);
            this.Controls.SetChildIndex(this.btnAddContact, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.gpxContactDetail.ResumeLayout(false);
            this.gpxContactDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
