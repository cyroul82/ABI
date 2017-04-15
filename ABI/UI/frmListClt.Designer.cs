namespace ABI.UI
{
    partial class frmListClt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListClt));
            this.clientDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlClients = new System.Windows.Forms.TabControl();
            this.ClientListTab = new System.Windows.Forms.TabPage();
            this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelSearchClient = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDspAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.rbSupEgal = new System.Windows.Forms.RadioButton();
            this.rbInfEgal = new System.Windows.Forms.RadioButton();
            this.rbEgal = new System.Windows.Forms.RadioButton();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.panelControlClient = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDsp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseTabs = new System.Windows.Forms.Button();
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelListClient = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).BeginInit();
            this.tabControlClients.SuspendLayout();
            this.ClientListTab.SuspendLayout();
            this.contextMenuStripTab.SuspendLayout();
            this.flowLayoutPanelSearchClient.SuspendLayout();
            this.panelControlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.panelListClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientDBBindingSource
            // 
            this.clientDBBindingSource.DataSource = typeof(ABI.ClientDB);
            // 
            // tabControlClients
            // 
            this.tabControlClients.Controls.Add(this.ClientListTab);
            this.tabControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClients.Location = new System.Drawing.Point(0, 0);
            this.tabControlClients.Name = "tabControlClients";
            this.tabControlClients.SelectedIndex = 0;
            this.tabControlClients.Size = new System.Drawing.Size(960, 600);
            this.tabControlClients.TabIndex = 3;
            this.tabControlClients.SelectedIndexChanged += new System.EventHandler(this.tabControlClientDetail_SelectedIndexChanged);
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
            // flowLayoutPanelSearchClient
            // 
            this.flowLayoutPanelSearchClient.AutoSize = true;
            this.flowLayoutPanelSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelSearchClient.Controls.Add(this.lblSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.cbxSearch);
            this.flowLayoutPanelSearchClient.Controls.Add(this.txtSearchClient);
            this.flowLayoutPanelSearchClient.Controls.Add(this.rbEgal);
            this.flowLayoutPanelSearchClient.Controls.Add(this.rbInfEgal);
            this.flowLayoutPanelSearchClient.Controls.Add(this.rbSupEgal);
            this.flowLayoutPanelSearchClient.Controls.Add(this.cbxType);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnSearch);
            this.flowLayoutPanelSearchClient.Controls.Add(this.btnDspAll);
            this.flowLayoutPanelSearchClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelSearchClient.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSearchClient.Name = "flowLayoutPanelSearchClient";
            this.flowLayoutPanelSearchClient.Size = new System.Drawing.Size(952, 62);
            this.flowLayoutPanelSearchClient.TabIndex = 1;
            // 
            // btnDspAll
            // 
            this.btnDspAll.Location = new System.Drawing.Point(3, 32);
            this.btnDspAll.Name = "btnDspAll";
            this.btnDspAll.Size = new System.Drawing.Size(75, 23);
            this.btnDspAll.TabIndex = 4;
            this.btnDspAll.Text = "Réinitialiser";
            this.btnDspAll.UseVisualStyleBackColor = true;
            this.btnDspAll.Click += new System.EventHandler(this.btnToutAfficher_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(842, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Recherche";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(715, 3);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 10;
            this.cbxType.Visible = false;
            // 
            // rbSupEgal
            // 
            this.rbSupEgal.AutoSize = true;
            this.rbSupEgal.Location = new System.Drawing.Point(672, 3);
            this.rbSupEgal.Name = "rbSupEgal";
            this.rbSupEgal.Size = new System.Drawing.Size(37, 17);
            this.rbSupEgal.TabIndex = 6;
            this.rbSupEgal.TabStop = true;
            this.rbSupEgal.Text = ">=";
            this.rbSupEgal.UseVisualStyleBackColor = true;
            this.rbSupEgal.Visible = false;
            // 
            // rbInfEgal
            // 
            this.rbInfEgal.AutoSize = true;
            this.rbInfEgal.Location = new System.Drawing.Point(629, 3);
            this.rbInfEgal.Name = "rbInfEgal";
            this.rbInfEgal.Size = new System.Drawing.Size(37, 17);
            this.rbInfEgal.TabIndex = 7;
            this.rbInfEgal.TabStop = true;
            this.rbInfEgal.Text = "<=";
            this.rbInfEgal.UseVisualStyleBackColor = true;
            this.rbInfEgal.Visible = false;
            // 
            // rbEgal
            // 
            this.rbEgal.AutoSize = true;
            this.rbEgal.Location = new System.Drawing.Point(592, 3);
            this.rbEgal.Name = "rbEgal";
            this.rbEgal.Size = new System.Drawing.Size(31, 17);
            this.rbEgal.TabIndex = 8;
            this.rbEgal.TabStop = true;
            this.rbEgal.Text = "=";
            this.rbEgal.UseVisualStyleBackColor = true;
            this.rbEgal.Visible = false;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(205, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(381, 20);
            this.txtSearchClient.TabIndex = 0;
            this.txtSearchClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchClient_KeyUp);
            // 
            // cbxSearch
            // 
            this.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Location = new System.Drawing.Point(78, 3);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(121, 21);
            this.cbxSearch.TabIndex = 5;
            this.cbxSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
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
            // panelControlClient
            // 
            this.panelControlClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControlClient.Controls.Add(this.btnCloseTabs);
            this.panelControlClient.Controls.Add(this.btnClose);
            this.panelControlClient.Controls.Add(this.btnAdd);
            this.panelControlClient.Controls.Add(this.btnDsp);
            this.panelControlClient.Controls.Add(this.btnDel);
            this.panelControlClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlClient.Location = new System.Drawing.Point(0, 62);
            this.panelControlClient.Name = "panelControlClient";
            this.panelControlClient.Size = new System.Drawing.Size(113, 512);
            this.panelControlClient.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(21, 41);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Supprimer";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnDsp
            // 
            this.btnDsp.Location = new System.Drawing.Point(21, 70);
            this.btnDsp.Name = "btnDsp";
            this.btnDsp.Size = new System.Drawing.Size(75, 23);
            this.btnDsp.TabIndex = 4;
            this.btnDsp.Text = "Afficher";
            this.btnDsp.UseVisualStyleBackColor = true;
            this.btnDsp.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(21, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnCloseTabs
            // 
            this.btnCloseTabs.Location = new System.Drawing.Point(21, 99);
            this.btnCloseTabs.Name = "btnCloseTabs";
            this.btnCloseTabs.Size = new System.Drawing.Size(75, 41);
            this.btnCloseTabs.TabIndex = 6;
            this.btnCloseTabs.Text = "Fermer tous les onglets";
            this.btnCloseTabs.UseVisualStyleBackColor = true;
            this.btnCloseTabs.Click += new System.EventHandler(this.btnFermerOnglets_Click);
            // 
            // grdClient
            // 
            this.grdClient.AllowUserToAddRows = false;
            this.grdClient.AllowUserToDeleteRows = false;
            this.grdClient.AutoGenerateColumns = false;
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.grdClient.DataSource = this.clientDBBindingSource;
            this.grdClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClient.Location = new System.Drawing.Point(113, 87);
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClient.Size = new System.Drawing.Size(839, 487);
            this.grdClient.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ville";
            this.dataGridViewTextBoxColumn12.HeaderText = "ville";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "codePostal";
            this.dataGridViewTextBoxColumn11.HeaderText = "codePostal";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "rue";
            this.dataGridViewTextBoxColumn10.HeaderText = "rue";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "telephone";
            this.dataGridViewTextBoxColumn9.HeaderText = "telephone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "comment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ca";
            this.dataGridViewTextBoxColumn7.HeaderText = "ca";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "effectifs";
            this.dataGridViewTextBoxColumn6.HeaderText = "effectifs";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nature";
            this.dataGridViewTextBoxColumn5.HeaderText = "nature";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "activite";
            this.dataGridViewTextBoxColumn4.HeaderText = "activite";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn3.HeaderText = "type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "raisonSocial";
            this.dataGridViewTextBoxColumn2.HeaderText = "raisonSocial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "idClient";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panelListClient
            // 
            this.panelListClient.Controls.Add(this.grdClient);
            this.panelListClient.Controls.Add(this.bindingNavigator1);
            this.panelListClient.Controls.Add(this.panelControlClient);
            this.panelListClient.Controls.Add(this.flowLayoutPanelSearchClient);
            this.panelListClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListClient.Location = new System.Drawing.Point(0, 0);
            this.panelListClient.Name = "panelListClient";
            this.panelListClient.Size = new System.Drawing.Size(952, 574);
            this.panelListClient.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(113, 62);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(839, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // frmListClt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.tabControlClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frmListClt";
            this.Text = "Liste des Clients";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).EndInit();
            this.tabControlClients.ResumeLayout(false);
            this.ClientListTab.ResumeLayout(false);
            this.contextMenuStripTab.ResumeLayout(false);
            this.flowLayoutPanelSearchClient.ResumeLayout(false);
            this.flowLayoutPanelSearchClient.PerformLayout();
            this.panelControlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.panelListClient.ResumeLayout(false);
            this.panelListClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlClients;
        private System.Windows.Forms.TabPage ClientListTab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerTousToolStripMenuItem;
        private System.Windows.Forms.BindingSource clientDBBindingSource;
        private System.Windows.Forms.Panel panelListClient;
        private System.Windows.Forms.DataGridView grdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panelControlClient;
        private System.Windows.Forms.Button btnCloseTabs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDsp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearchClient;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.RadioButton rbEgal;
        private System.Windows.Forms.RadioButton rbInfEgal;
        private System.Windows.Forms.RadioButton rbSupEgal;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDspAll;
    }
}