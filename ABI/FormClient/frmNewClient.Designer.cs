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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnFermerClient = new System.Windows.Forms.Button();
            this.gpbClientInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Size = new System.Drawing.Size(493, 444);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFermerClient);
            this.panel1.Controls.Add(this.btnAjouterClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(153, 18);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            // 
            // btnFermerClient
            // 
            this.btnFermerClient.Location = new System.Drawing.Point(258, 17);
            this.btnFermerClient.Name = "btnFermerClient";
            this.btnFermerClient.Size = new System.Drawing.Size(75, 23);
            this.btnFermerClient.TabIndex = 1;
            this.btnFermerClient.Text = "Fermer";
            this.btnFermerClient.UseVisualStyleBackColor = true;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(533, 536);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gpbClientInformation, 0);
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFermerClient;
        private System.Windows.Forms.Button btnAjouterClient;
    }
}
