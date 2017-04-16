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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDspClient));
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gpxContact = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contactDBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifierContact = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchContact = new System.Windows.Forms.TextBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.btnAnnulerModif = new System.Windows.Forms.Button();
            this.gpxDocument = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnAnnulerModifClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).BeginInit();
            this.gpbClientInformation.SuspendLayout();
            this.gpxContact.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBBindingNavigator)).BeginInit();
            this.contactDBBindingNavigator.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTxtCodePostal
            // 
            this.mTxtCodePostal.Enabled = false;
            // 
            // txtVille
            // 
            this.txtVille.Enabled = false;
            // 
            // txtRue
            // 
            this.txtRue.Enabled = false;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Size = new System.Drawing.Size(451, 105);
            // 
            // txtEffectif
            // 
            this.txtEffectif.Enabled = false;
            // 
            // txtCA
            // 
            this.txtCA.Enabled = false;
            // 
            // cbxNature
            // 
            this.cbxNature.Enabled = false;
            // 
            // cbxActivite
            // 
            this.cbxActivite.Enabled = false;
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Enabled = false;
            // 
            // cbxType
            // 
            this.cbxType.Enabled = false;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.AutoSize = true;
            this.gpbClientInformation.Controls.Add(this.btnAnnulerModifClient);
            this.gpbClientInformation.Controls.Add(this.btnModifierClient);
            this.gpbClientInformation.Dock = System.Windows.Forms.DockStyle.None;
            this.gpbClientInformation.Location = new System.Drawing.Point(20, 22);
            this.gpbClientInformation.Size = new System.Drawing.Size(484, 449);
            this.gpbClientInformation.Controls.SetChildIndex(this.lblClientNumber, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtIdClient, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.cbxType, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtRaisonSocial, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.cbxActivite, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.cbxNature, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtCA, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtEffectif, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtComment, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtRue, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtVille, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.txtTelephone, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.mTxtCodePostal, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.btnModifierClient, 0);
            this.gpbClientInformation.Controls.SetChildIndex(this.btnAnnulerModifClient, 0);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Enabled = false;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(20, 477);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermerClient_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(265, 25);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // gpxContact
            // 
            this.gpxContact.Controls.Add(this.panel2);
            this.gpxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxContact.Location = new System.Drawing.Point(0, 0);
            this.gpxContact.Name = "gpxContact";
            this.gpxContact.Padding = new System.Windows.Forms.Padding(10);
            this.gpxContact.Size = new System.Drawing.Size(437, 255);
            this.gpxContact.TabIndex = 2;
            this.gpxContact.TabStop = false;
            this.gpxContact.Text = "Contact";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.grdContact);
            this.panel2.Controls.Add(this.contactDBBindingNavigator);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 222);
            this.panel2.TabIndex = 1;
            // 
            // grdContact
            // 
            this.grdContact.AllowUserToAddRows = false;
            this.grdContact.AllowUserToDeleteRows = false;
            this.grdContact.AutoGenerateColumns = false;
            this.grdContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grdContact.DataSource = this.contactDBBindingSource;
            this.grdContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContact.Location = new System.Drawing.Point(112, 51);
            this.grdContact.MultiSelect = false;
            this.grdContact.Name = "grdContact";
            this.grdContact.ReadOnly = true;
            this.grdContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContact.Size = new System.Drawing.Size(305, 171);
            this.grdContact.TabIndex = 2;
            this.grdContact.SelectionChanged += new System.EventHandler(this.grdContact_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idContact";
            this.dataGridViewTextBoxColumn1.HeaderText = "idContact";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "idClient";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fonction";
            this.dataGridViewTextBoxColumn4.HeaderText = "fonction";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "telephone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ClientDB";
            this.dataGridViewTextBoxColumn7.HeaderText = "ClientDB";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // contactDBBindingSource
            // 
            this.contactDBBindingSource.DataSource = typeof(ABI.ObservableListSource<ABI.ContactDB>);
            // 
            // contactDBBindingNavigator
            // 
            this.contactDBBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactDBBindingNavigator.BindingSource = this.contactDBBindingSource;
            this.contactDBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactDBBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactDBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.contactDBBindingNavigatorSaveItem});
            this.contactDBBindingNavigator.Location = new System.Drawing.Point(112, 26);
            this.contactDBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactDBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactDBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactDBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactDBBindingNavigator.Name = "contactDBBindingNavigator";
            this.contactDBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactDBBindingNavigator.Size = new System.Drawing.Size(305, 25);
            this.contactDBBindingNavigator.TabIndex = 6;
            this.contactDBBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // contactDBBindingNavigatorSaveItem
            // 
            this.contactDBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactDBBindingNavigatorSaveItem.Enabled = false;
            this.contactDBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactDBBindingNavigatorSaveItem.Image")));
            this.contactDBBindingNavigatorSaveItem.Name = "contactDBBindingNavigatorSaveItem";
            this.contactDBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactDBBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Controls.Add(this.btnModifierContact);
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 196);
            this.panel3.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // btnModifierContact
            // 
            this.btnModifierContact.Location = new System.Drawing.Point(21, 70);
            this.btnModifierContact.Name = "btnModifierContact";
            this.btnModifierContact.Size = new System.Drawing.Size(75, 23);
            this.btnModifierContact.TabIndex = 3;
            this.btnModifierContact.Text = "Modifier";
            this.btnModifierContact.UseVisualStyleBackColor = true;
            this.btnModifierContact.Click += new System.EventHandler(this.btnModifierContact_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(21, 41);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimerContact_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.txtSearchContact);
            this.flowLayoutPanel1.Controls.Add(this.lblSearchClient);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtSearchContact
            // 
            this.txtSearchContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchContact.Location = new System.Drawing.Point(112, 3);
            this.txtSearchContact.Name = "txtSearchContact";
            this.txtSearchContact.Size = new System.Drawing.Size(302, 20);
            this.txtSearchContact.TabIndex = 4;
            this.txtSearchContact.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchContact_KeyUp);
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(37, 6);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(69, 13);
            this.lblSearchClient.TabIndex = 3;
            this.lblSearchClient.Text = "Recherche : ";
            // 
            // btnAnnulerModif
            // 
            this.btnAnnulerModif.Location = new System.Drawing.Point(345, 25);
            this.btnAnnulerModif.Name = "btnAnnulerModif";
            this.btnAnnulerModif.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerModif.TabIndex = 31;
            this.btnAnnulerModif.Text = "Annuler";
            this.btnAnnulerModif.UseVisualStyleBackColor = true;
            this.btnAnnulerModif.Visible = false;
            this.btnAnnulerModif.Click += new System.EventHandler(this.btnAnnulerModificationClient_Click);
            // 
            // gpxDocument
            // 
            this.gpxDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxDocument.Location = new System.Drawing.Point(0, 0);
            this.gpxDocument.Name = "gpxDocument";
            this.gpxDocument.Size = new System.Drawing.Size(437, 253);
            this.gpxDocument.TabIndex = 3;
            this.gpxDocument.TabStop = false;
            this.gpxDocument.Text = "Document";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(519, 23);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gpxContact);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpxDocument);
            this.splitContainer1.Size = new System.Drawing.Size(437, 512);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(277, 25);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(75, 23);
            this.btnModifierClient.TabIndex = 31;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnAnnulerModifClient
            // 
            this.btnAnnulerModifClient.Location = new System.Drawing.Point(358, 25);
            this.btnAnnulerModifClient.Name = "btnAnnulerModifClient";
            this.btnAnnulerModifClient.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerModifClient.TabIndex = 32;
            this.btnAnnulerModifClient.Text = "Annuler";
            this.btnAnnulerModifClient.UseVisualStyleBackColor = true;
            this.btnAnnulerModifClient.Visible = false;
            this.btnAnnulerModifClient.Click += new System.EventHandler(this.btnAnnulerModificationClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(101, 477);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClient.TabIndex = 5;
            this.btnDeleteClient.Text = "Supprimer";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // frmDspClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(976, 600);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frmDspClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDspClient_Load);
            this.Controls.SetChildIndex(this.gpbClientInformation, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnDeleteClient, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRaisonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEffectif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCA)).EndInit();
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            this.gpxContact.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBBindingNavigator)).EndInit();
            this.contactDBBindingNavigator.ResumeLayout(false);
            this.contactDBBindingNavigator.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox gpxContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifierContact;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearchContact;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.Button btnAnnulerModif;
        private System.Windows.Forms.GroupBox gpxDocument;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAnnulerModifClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource contactDBBindingSource;
        private System.Windows.Forms.BindingNavigator contactDBBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contactDBBindingNavigatorSaveItem;
    }
}
