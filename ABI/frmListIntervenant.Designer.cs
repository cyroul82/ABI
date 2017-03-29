namespace ABI
{
    partial class frmListIntervenant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSupprimerInterveant = new System.Windows.Forms.Button();
            this.bntAddIntervenant = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblClient);
            this.flowLayoutPanel1.Controls.Add(this.txtClient);
            this.flowLayoutPanel1.Controls.Add(this.btnDisplay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(793, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblClient
            // 
            this.lblClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(3, 8);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(42, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client : ";
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(51, 4);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(135, 20);
            this.txtClient.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(192, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Afficher";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colFonction,
            this.colTel,
            this.colEmail,
            this.colTotalHeure});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // colFonction
            // 
            this.colFonction.HeaderText = "Fonction";
            this.colFonction.Name = "colFonction";
            this.colFonction.ReadOnly = true;
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Téléphone";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colTotalHeure
            // 
            this.colTotalHeure.HeaderText = "Total Heures";
            this.colTotalHeure.Name = "colTotalHeure";
            this.colTotalHeure.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnSupprimerInterveant);
            this.flowLayoutPanel2.Controls.Add(this.bntAddIntervenant);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 359);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(793, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnSupprimerInterveant
            // 
            this.btnSupprimerInterveant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupprimerInterveant.Location = new System.Drawing.Point(715, 3);
            this.btnSupprimerInterveant.Name = "btnSupprimerInterveant";
            this.btnSupprimerInterveant.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerInterveant.TabIndex = 0;
            this.btnSupprimerInterveant.Text = "Supprimer";
            this.btnSupprimerInterveant.UseVisualStyleBackColor = true;
            // 
            // bntAddIntervenant
            // 
            this.bntAddIntervenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntAddIntervenant.Location = new System.Drawing.Point(634, 3);
            this.bntAddIntervenant.Name = "bntAddIntervenant";
            this.bntAddIntervenant.Size = new System.Drawing.Size(75, 23);
            this.bntAddIntervenant.TabIndex = 1;
            this.bntAddIntervenant.Text = "Ajouter";
            this.bntAddIntervenant.UseVisualStyleBackColor = true;
            // 
            // frmListIntervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 388);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmListIntervenant";
            this.Text = "Intervenants";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHeure;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSupprimerInterveant;
        private System.Windows.Forms.Button bntAddIntervenant;
    }
}