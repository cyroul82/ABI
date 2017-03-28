namespace ABI
{
    partial class frmNewClient
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCancelClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(308, 685);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Ajouter";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnCancelClient
            // 
            this.btnCancelClient.Location = new System.Drawing.Point(392, 685);
            this.btnCancelClient.Name = "btnCancelClient";
            this.btnCancelClient.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClient.TabIndex = 2;
            this.btnCancelClient.Text = "Annuler";
            this.btnCancelClient.UseVisualStyleBackColor = true;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(730, 723);
            this.Controls.Add(this.btnCancelClient);
            this.Controls.Add(this.btnAddClient);
            this.Name = "frmNewClient";
            this.Controls.SetChildIndex(this.btnAddClient, 0);
            this.Controls.SetChildIndex(this.btnCancelClient, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnCancelClient;
    }
}
