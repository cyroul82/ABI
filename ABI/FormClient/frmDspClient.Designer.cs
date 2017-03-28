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
            this.gpbClientInformation.SuspendLayout();
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
            this.gpbClientInformation.Size = new System.Drawing.Size(490, 441);
            // 
            // frmDspClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(530, 481);
            this.Name = "frmDspClient";
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
	}
}
