﻿namespace ABI
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
            this.btnAnnulerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.gpbClientInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Size = new System.Drawing.Size(493, 441);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnnulerClient);
            this.panel1.Controls.Add(this.btnAjouterClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnAnnulerClient
            // 
            this.btnAnnulerClient.Location = new System.Drawing.Point(234, 18);
            this.btnAnnulerClient.Name = "btnAnnulerClient";
            this.btnAnnulerClient.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerClient.TabIndex = 1;
            this.btnAnnulerClient.Text = "Annuler";
            this.btnAnnulerClient.UseVisualStyleBackColor = true;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(153, 18);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Enregistrer";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(533, 533);
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
        private System.Windows.Forms.Button btnAnnulerClient;
        private System.Windows.Forms.Button btnAjouterClient;
    }
}