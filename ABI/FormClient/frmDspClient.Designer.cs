﻿namespace ABI
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gpbClientInformation.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Enabled = false;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Size = new System.Drawing.Size(490, 437);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(287, 6);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(137, 6);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // frmDspClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(530, 516);
            this.Controls.Add(this.panel1);
            this.Name = "frmDspClient";
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
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
    }
}
