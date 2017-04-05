﻿namespace ABI.UI
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
            this.rbEgal = new System.Windows.Forms.RadioButton();
            this.rbInfEgal = new System.Windows.Forms.RadioButton();
            this.rbSupEgal = new System.Windows.Forms.RadioButton();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.btnToutAfficher = new System.Windows.Forms.Button();
            this.tabControlClientDetail = new System.Windows.Forms.TabControl();
            this.ClientListTab = new System.Windows.Forms.TabPage();
            this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
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
            this.grdClient.Location = new System.Drawing.Point(113, 62);
            this.grdClient.MultiSelect = false;
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClient.Size = new System.Drawing.Size(839, 512);
            this.grdClient.TabIndex = 8;
            this.grdClient.SelectionChanged += new System.EventHandler(this.grdClient_SelectionChanged);
            this.grdClient.DoubleClick += new System.EventHandler(this.grdClient_DoubleClick);
            this.grdClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdClient_MouseUp);
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
            this.panelControlClient.Location = new System.Drawing.Point(0, 62);
            this.panelControlClient.Name = "panelControlClient";
            this.panelControlClient.Size = new System.Drawing.Size(113, 512);
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
            this.btnFermer.Location = new System.Drawing.Point(21, 479);
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
            this.flowLayoutPanelSearchClient.Controls.Add(this.rbEgal);
            this.flowLayoutPanelSearchClient.Controls.Add(this.rbInfEgal);
            this.flowLayoutPanelSearchClient.Controls.Add(this.rbSupEgal);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnSearch);
            this.flowLayoutPanelSearchClient.Controls.Add(this.cbxSearch);
            this.flowLayoutPanelSearchClient.Controls.Add(this.cbxType);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnToutAfficher);
            this.flowLayoutPanelSearchClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelSearchClient.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSearchClient.Name = "flowLayoutPanelSearchClient";
            this.flowLayoutPanelSearchClient.Size = new System.Drawing.Size(952, 62);
            this.flowLayoutPanelSearchClient.TabIndex = 1;
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(3, 8);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(69, 13);
            this.lblSearchClient.TabIndex = 3;
            this.lblSearchClient.Text = "Recherche : ";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(78, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(381, 20);
            this.txtSearchClient.TabIndex = 0;
            this.txtSearchClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchClient_KeyUp);
            // 
            // rbEgal
            // 
            this.rbEgal.AutoSize = true;
            this.rbEgal.Location = new System.Drawing.Point(465, 3);
            this.rbEgal.Name = "rbEgal";
            this.rbEgal.Size = new System.Drawing.Size(31, 17);
            this.rbEgal.TabIndex = 8;
            this.rbEgal.TabStop = true;
            this.rbEgal.Text = "=";
            this.rbEgal.UseVisualStyleBackColor = true;
            this.rbEgal.Visible = false;
            // 
            // rbInfEgal
            // 
            this.rbInfEgal.AutoSize = true;
            this.rbInfEgal.Location = new System.Drawing.Point(502, 3);
            this.rbInfEgal.Name = "rbInfEgal";
            this.rbInfEgal.Size = new System.Drawing.Size(37, 17);
            this.rbInfEgal.TabIndex = 7;
            this.rbInfEgal.TabStop = true;
            this.rbInfEgal.Text = "<=";
            this.rbInfEgal.UseVisualStyleBackColor = true;
            this.rbInfEgal.Visible = false;
            // 
            // rbSupEgal
            // 
            this.rbSupEgal.AutoSize = true;
            this.rbSupEgal.Location = new System.Drawing.Point(545, 3);
            this.rbSupEgal.Name = "rbSupEgal";
            this.rbSupEgal.Size = new System.Drawing.Size(37, 17);
            this.rbSupEgal.TabIndex = 6;
            this.rbSupEgal.TabStop = true;
            this.rbSupEgal.Text = ">=";
            this.rbSupEgal.UseVisualStyleBackColor = true;
            this.rbSupEgal.Visible = false;
            // 
            // cbxSearch
            // 
            this.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Location = new System.Drawing.Point(653, 3);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(121, 21);
            this.cbxSearch.TabIndex = 5;
            this.cbxSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
            // 
            // btnToutAfficher
            // 
            this.btnToutAfficher.Location = new System.Drawing.Point(3, 32);
            this.btnToutAfficher.Name = "btnToutAfficher";
            this.btnToutAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnToutAfficher.TabIndex = 4;
            this.btnToutAfficher.Text = "Réinitialiser";
            this.btnToutAfficher.UseVisualStyleBackColor = true;
            this.btnToutAfficher.Click += new System.EventHandler(this.btnToutAfficher_Click);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(588, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(780, 3);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 10;
            this.cbxType.Visible = false;
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
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.RadioButton rbSupEgal;
        private System.Windows.Forms.RadioButton rbEgal;
        private System.Windows.Forms.RadioButton rbInfEgal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxType;
    }
}