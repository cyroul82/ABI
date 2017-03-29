namespace ABI.UI
{
    partial class frmClient
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
            this.panelListClient = new System.Windows.Forms.Panel();
            this.panelControlClient = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanelSearchClient = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.tabControlClientDetail = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelListClient.SuspendLayout();
            this.panelControlClient.SuspendLayout();
            this.flowLayoutPanelSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListClient
            // 
            this.panelListClient.Controls.Add(this.grdClient);
            this.panelListClient.Controls.Add(this.panelControlClient);
            this.panelListClient.Controls.Add(this.flowLayoutPanelSearchClient);
            this.panelListClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListClient.Location = new System.Drawing.Point(0, 0);
            this.panelListClient.Name = "panelListClient";
            this.panelListClient.Size = new System.Drawing.Size(580, 509);
            this.panelListClient.TabIndex = 0;
            // 
            // panelControlClient
            // 
            this.panelControlClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControlClient.Controls.Add(this.btnAjouter);
            this.panelControlClient.Controls.Add(this.btnAfficher);
            this.panelControlClient.Controls.Add(this.btnSupprimer);
            this.panelControlClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlClient.Location = new System.Drawing.Point(0, 33);
            this.panelControlClient.Name = "panelControlClient";
            this.panelControlClient.Size = new System.Drawing.Size(113, 476);
            this.panelControlClient.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(21, 70);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(21, 41);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSearchClient
            // 
            this.flowLayoutPanelSearchClient.AutoSize = true;
            this.flowLayoutPanelSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelSearchClient.Controls.Add(this.lblSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.txtSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnSearchClient);
            this.flowLayoutPanelSearchClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelSearchClient.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSearchClient.Name = "flowLayoutPanelSearchClient";
            this.flowLayoutPanelSearchClient.Padding = new System.Windows.Forms.Padding(113, 0, 0, 0);
            this.flowLayoutPanelSearchClient.Size = new System.Drawing.Size(580, 33);
            this.flowLayoutPanelSearchClient.TabIndex = 0;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchClient.Location = new System.Drawing.Point(474, 3);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 5;
            this.btnSearchClient.Text = "Ok";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(191, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(277, 20);
            this.txtSearchClient.TabIndex = 4;
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(116, 8);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(69, 13);
            this.lblSearchClient.TabIndex = 3;
            this.lblSearchClient.Text = "Recherche : ";
            // 
            // grdClient
            // 
            this.grdClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClient.Location = new System.Drawing.Point(113, 33);
            this.grdClient.MultiSelect = false;
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClient.Size = new System.Drawing.Size(467, 476);
            this.grdClient.TabIndex = 1;
            this.grdClient.SelectionChanged += new System.EventHandler(this.grdClient_SelectionChanged);
            // 
            // tabControlClientDetail
            // 
            this.tabControlClientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClientDetail.Location = new System.Drawing.Point(0, 0);
            this.tabControlClientDetail.Name = "tabControlClientDetail";
            this.tabControlClientDetail.SelectedIndex = 0;
            this.tabControlClientDetail.Size = new System.Drawing.Size(530, 509);
            this.tabControlClientDetail.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelListClient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlClientDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1114, 509);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.TabIndex = 3;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 509);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmClient";
            this.Text = "Liste des Clients";
            this.panelListClient.ResumeLayout(false);
            this.panelListClient.PerformLayout();
            this.panelControlClient.ResumeLayout(false);
            this.flowLayoutPanelSearchClient.ResumeLayout(false);
            this.flowLayoutPanelSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListClient;
        private System.Windows.Forms.DataGridView grdClient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearchClient;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Panel panelControlClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.TabControl tabControlClientDetail;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}