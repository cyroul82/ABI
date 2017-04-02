namespace ABI.UI
{
    partial class frmCommercial
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
            this.components = new System.ComponentModel.Container();
            this.panelListClient = new System.Windows.Forms.Panel();
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.panelControlClient = new System.Windows.Forms.Panel();
            this.btnFermerOnglets = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanelSearchClient = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.tabControlClientDetail = new System.Windows.Forms.TabControl();
            this.ClientListTab = new System.Windows.Forms.TabPage();
            this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToutAfficher = new System.Windows.Forms.Button();
            this.panelListClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.panelControlClient.SuspendLayout();
            this.flowLayoutPanelSearchClient.SuspendLayout();
            this.tabControlClientDetail.SuspendLayout();
            this.ClientListTab.SuspendLayout();
            this.contextMenuStripTab.SuspendLayout();
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
            this.panelListClient.Size = new System.Drawing.Size(952, 574);
            this.panelListClient.TabIndex = 0;
            // 
            // grdClient
            // 
            this.grdClient.AllowUserToAddRows = false;
            this.grdClient.AllowUserToDeleteRows = false;
            this.grdClient.AllowUserToOrderColumns = true;
            this.grdClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClient.Location = new System.Drawing.Point(113, 33);
            this.grdClient.MultiSelect = false;
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClient.Size = new System.Drawing.Size(839, 541);
            this.grdClient.TabIndex = 8;
            this.grdClient.SelectionChanged += new System.EventHandler(this.grdClient_SelectionChanged);
            this.grdClient.DoubleClick += new System.EventHandler(this.grdClient_DoubleClick);
            // 
            // panelControlClient
            // 
            this.panelControlClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControlClient.Controls.Add(this.btnFermerOnglets);
            this.panelControlClient.Controls.Add(this.btnFermer);
            this.panelControlClient.Controls.Add(this.btnAjouter);
            this.panelControlClient.Controls.Add(this.btnAfficher);
            this.panelControlClient.Controls.Add(this.btnSupprimer);
            this.panelControlClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlClient.Location = new System.Drawing.Point(0, 33);
            this.panelControlClient.Name = "panelControlClient";
            this.panelControlClient.Size = new System.Drawing.Size(113, 541);
            this.panelControlClient.TabIndex = 2;
            // 
            // btnFermerOnglets
            // 
            this.btnFermerOnglets.Location = new System.Drawing.Point(21, 99);
            this.btnFermerOnglets.Name = "btnFermerOnglets";
            this.btnFermerOnglets.Size = new System.Drawing.Size(75, 41);
            this.btnFermerOnglets.TabIndex = 6;
            this.btnFermerOnglets.Text = "Fermer tous les onglets";
            this.btnFermerOnglets.UseVisualStyleBackColor = true;
            this.btnFermerOnglets.Click += new System.EventHandler(this.btnFermerOnglets_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFermer.Location = new System.Drawing.Point(21, 508);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(21, 70);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(21, 41);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // flowLayoutPanelSearchClient
            // 
            this.flowLayoutPanelSearchClient.AutoSize = true;
            this.flowLayoutPanelSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelSearchClient.Controls.Add(this.lblSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.txtSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnToutAfficher);
            this.flowLayoutPanelSearchClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelSearchClient.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSearchClient.Name = "flowLayoutPanelSearchClient";
            this.flowLayoutPanelSearchClient.Padding = new System.Windows.Forms.Padding(113, 0, 0, 0);
            this.flowLayoutPanelSearchClient.Size = new System.Drawing.Size(952, 33);
            this.flowLayoutPanelSearchClient.TabIndex = 1;
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
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(191, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(381, 20);
            this.txtSearchClient.TabIndex = 0;
            this.txtSearchClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchClient_KeyUp);
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchClient.Location = new System.Drawing.Point(578, 3);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 1;
            this.btnSearchClient.Text = "Ok";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // tabControlClientDetail
            // 
            this.tabControlClientDetail.Controls.Add(this.ClientListTab);
            this.tabControlClientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClientDetail.Location = new System.Drawing.Point(0, 0);
            this.tabControlClientDetail.Name = "tabControlClientDetail";
            this.tabControlClientDetail.SelectedIndex = 0;
            this.tabControlClientDetail.Size = new System.Drawing.Size(960, 600);
            this.tabControlClientDetail.TabIndex = 3;
            this.tabControlClientDetail.SelectedIndexChanged += new System.EventHandler(this.tabControlClientDetail_SelectedIndexChanged);
            this.tabControlClientDetail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControlClientDetail_MouseUp);
            // 
            // ClientListTab
            // 
            this.ClientListTab.Controls.Add(this.panelListClient);
            this.ClientListTab.Location = new System.Drawing.Point(4, 22);
            this.ClientListTab.Name = "ClientListTab";
            this.ClientListTab.Size = new System.Drawing.Size(952, 574);
            this.ClientListTab.TabIndex = 0;
            this.ClientListTab.Text = "Liste Clients";
            this.ClientListTab.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripTab
            // 
            this.contextMenuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fermerToolStripMenuItem,
            this.fermerTousToolStripMenuItem});
            this.contextMenuStripTab.Name = "contextMenuStripTab";
            this.contextMenuStripTab.Size = new System.Drawing.Size(140, 48);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // fermerTousToolStripMenuItem
            // 
            this.fermerTousToolStripMenuItem.Name = "fermerTousToolStripMenuItem";
            this.fermerTousToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fermerTousToolStripMenuItem.Text = "Fermer Tous";
            this.fermerTousToolStripMenuItem.Click += new System.EventHandler(this.fermerTousToolStripMenuItem_Click);
            // 
            // btnToutAfficher
            // 
            this.btnToutAfficher.Location = new System.Drawing.Point(659, 3);
            this.btnToutAfficher.Name = "btnToutAfficher";
            this.btnToutAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnToutAfficher.TabIndex = 4;
            this.btnToutAfficher.Text = "Tout Afficher";
            this.btnToutAfficher.UseVisualStyleBackColor = true;
            this.btnToutAfficher.Click += new System.EventHandler(this.btnToutAfficher_Click);
            // 
            // frmCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.tabControlClientDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frmCommercial";
            this.Text = "Liste des Clients";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.panelListClient.ResumeLayout(false);
            this.panelListClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.panelControlClient.ResumeLayout(false);
            this.flowLayoutPanelSearchClient.ResumeLayout(false);
            this.flowLayoutPanelSearchClient.PerformLayout();
            this.tabControlClientDetail.ResumeLayout(false);
            this.ClientListTab.ResumeLayout(false);
            this.contextMenuStripTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage ClientListTab;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnFermerOnglets;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerTousToolStripMenuItem;
        private System.Windows.Forms.Button btnToutAfficher;
    }
}