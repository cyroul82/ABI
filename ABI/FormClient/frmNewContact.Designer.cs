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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(60, 176);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Ajouter";
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmNewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(316, 211);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddContact);
            this.Name = "frmNewContact";
            this.Controls.SetChildIndex(this.btnAddContact, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button button2;
    }
}
