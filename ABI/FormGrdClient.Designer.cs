namespace ABI
{
    partial class FormGrdClient
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
            this.splClient = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.gpbClientInformation = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.lblChiffreAffaire = new System.Windows.Forms.Label();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.cbxActivity = new System.Windows.Forms.ComboBox();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.txtRaisonSocial = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRaisonSocial = new System.Windows.Forms.Label();
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.tabIntervenant = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splClient)).BeginInit();
            this.splClient.Panel1.SuspendLayout();
            this.splClient.Panel2.SuspendLayout();
            this.splClient.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.gpbClientInformation.SuspendLayout();
            this.tabIntervenant.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splClient
            // 
            this.splClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splClient.Location = new System.Drawing.Point(0, 0);
            this.splClient.Name = "splClient";
            // 
            // splClient.Panel1
            // 
            this.splClient.Panel1.Controls.Add(this.treeView1);
            this.splClient.Panel1.Controls.Add(this.flowLayoutPanel3);
            this.splClient.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splClient.Panel1MinSize = 292;
            // 
            // splClient.Panel2
            // 
            this.splClient.Panel2.Controls.Add(this.tabControlClient);
            this.splClient.Size = new System.Drawing.Size(1112, 725);
            this.splClient.SplitterDistance = 292;
            this.splClient.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(288, 663);
            this.treeView1.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.btnAddClient);
            this.flowLayoutPanel3.Controls.Add(this.btnDeleteClient);
            this.flowLayoutPanel3.Controls.Add(this.btnEditClient);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 692);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(288, 29);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddClient.Location = new System.Drawing.Point(3, 3);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Ajouter";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteClient.Location = new System.Drawing.Point(84, 3);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClient.TabIndex = 1;
            this.btnDeleteClient.Text = "Supprimer";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditClient.Location = new System.Drawing.Point(165, 3);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(75, 23);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Editer";
            this.btnEditClient.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblSearchClient);
            this.flowLayoutPanel1.Controls.Add(this.txtSearchClient);
            this.flowLayoutPanel1.Controls.Add(this.btnSearchClient);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(3, 8);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(69, 13);
            this.lblSearchClient.TabIndex = 0;
            this.lblSearchClient.Text = "Recherche : ";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.Location = new System.Drawing.Point(78, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(126, 20);
            this.txtSearchClient.TabIndex = 1;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(210, 3);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "Ok";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // tabControlClient
            // 
            this.tabControlClient.Controls.Add(this.tabClient);
            this.tabControlClient.Controls.Add(this.tabIntervenant);
            this.tabControlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClient.Location = new System.Drawing.Point(0, 0);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(812, 721);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabClient
            // 
            this.tabClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabClient.Controls.Add(this.flowLayoutPanel2);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabClient.Size = new System.Drawing.Size(804, 695);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Client";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // gpbClientInformation
            // 
            this.gpbClientInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbClientInformation.Controls.Add(this.textBox3);
            this.gpbClientInformation.Controls.Add(this.lblTown);
            this.gpbClientInformation.Controls.Add(this.txtCodePostal);
            this.gpbClientInformation.Controls.Add(this.lblCodePostal);
            this.gpbClientInformation.Controls.Add(this.txtAddress);
            this.gpbClientInformation.Controls.Add(this.lblAddress);
            this.gpbClientInformation.Controls.Add(this.txtCommentaire);
            this.gpbClientInformation.Controls.Add(this.lblCommentaire);
            this.gpbClientInformation.Controls.Add(this.textBox1);
            this.gpbClientInformation.Controls.Add(this.lblEffectif);
            this.gpbClientInformation.Controls.Add(this.txtCA);
            this.gpbClientInformation.Controls.Add(this.lblChiffreAffaire);
            this.gpbClientInformation.Controls.Add(this.cbxNature);
            this.gpbClientInformation.Controls.Add(this.lblNature);
            this.gpbClientInformation.Controls.Add(this.cbxActivity);
            this.gpbClientInformation.Controls.Add(this.lblDomaine);
            this.gpbClientInformation.Controls.Add(this.txtRaisonSocial);
            this.gpbClientInformation.Controls.Add(this.cbxType);
            this.gpbClientInformation.Controls.Add(this.txtNumero);
            this.gpbClientInformation.Controls.Add(this.lblType);
            this.gpbClientInformation.Controls.Add(this.lblRaisonSocial);
            this.gpbClientInformation.Controls.Add(this.lblClientNumber);
            this.gpbClientInformation.Location = new System.Drawing.Point(3, 3);
            this.gpbClientInformation.MinimumSize = new System.Drawing.Size(507, 452);
            this.gpbClientInformation.Name = "gpbClientInformation";
            this.gpbClientInformation.Size = new System.Drawing.Size(507, 452);
            this.gpbClientInformation.TabIndex = 1;
            this.gpbClientInformation.TabStop = false;
            this.gpbClientInformation.Text = "Information Société";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(344, 241);
            this.textBox3.MaximumSize = new System.Drawing.Size(121, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 27;
            // 
            // lblTown
            // 
            this.lblTown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(284, 244);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(35, 13);
            this.lblTown.TabIndex = 26;
            this.lblTown.Text = "Ville : ";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodePostal.Location = new System.Drawing.Point(138, 237);
            this.txtCodePostal.MaximumSize = new System.Drawing.Size(94, 20);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(93, 20);
            this.txtCodePostal.TabIndex = 25;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(11, 240);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(73, 13);
            this.lblCodePostal.TabIndex = 24;
            this.lblCodePostal.Text = "Code Postal : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(137, 203);
            this.txtAddress.MaximumSize = new System.Drawing.Size(328, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(327, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 207);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 13);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Adresse : ";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCommentaire.Location = new System.Drawing.Point(14, 321);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(444, 115);
            this.txtCommentaire.TabIndex = 17;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(12, 305);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(82, 13);
            this.lblCommentaire.TabIndex = 16;
            this.lblCommentaire.Text = "Commentaires : ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(345, 128);
            this.textBox1.MaximumSize = new System.Drawing.Size(78, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 15;
            // 
            // lblEffectif
            // 
            this.lblEffectif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(284, 132);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(54, 13);
            this.lblEffectif.TabIndex = 14;
            this.lblEffectif.Text = "Effectifs : ";
            // 
            // txtCA
            // 
            this.txtCA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCA.Location = new System.Drawing.Point(137, 167);
            this.txtCA.MaximumSize = new System.Drawing.Size(121, 20);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(120, 20);
            this.txtCA.TabIndex = 11;
            // 
            // lblChiffreAffaire
            // 
            this.lblChiffreAffaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChiffreAffaire.AutoSize = true;
            this.lblChiffreAffaire.Location = new System.Drawing.Point(12, 171);
            this.lblChiffreAffaire.Name = "lblChiffreAffaire";
            this.lblChiffreAffaire.Size = new System.Drawing.Size(92, 13);
            this.lblChiffreAffaire.TabIndex = 10;
            this.lblChiffreAffaire.Text = "Chiffre d\'Affaires : ";
            // 
            // cbxNature
            // 
            this.cbxNature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.cbxNature.Location = new System.Drawing.Point(138, 128);
            this.cbxNature.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(121, 21);
            this.cbxNature.TabIndex = 9;
            // 
            // lblNature
            // 
            this.lblNature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(12, 132);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(48, 13);
            this.lblNature.TabIndex = 8;
            this.lblNature.Text = "Nature : ";
            // 
            // cbxActivity
            // 
            this.cbxActivity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Location = new System.Drawing.Point(137, 92);
            this.cbxActivity.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(120, 21);
            this.cbxActivity.TabIndex = 7;
            // 
            // lblDomaine
            // 
            this.lblDomaine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(11, 96);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(104, 13);
            this.lblDomaine.TabIndex = 6;
            this.lblDomaine.Text = "Domaine d\'Activité : ";
            // 
            // txtRaisonSocial
            // 
            this.txtRaisonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaisonSocial.Location = new System.Drawing.Point(138, 57);
            this.txtRaisonSocial.MaximumSize = new System.Drawing.Size(328, 20);
            this.txtRaisonSocial.Name = "txtRaisonSocial";
            this.txtRaisonSocial.Size = new System.Drawing.Size(327, 20);
            this.txtRaisonSocial.TabIndex = 5;
            // 
            // cbxType
            // 
            this.cbxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.cbxType.Location = new System.Drawing.Point(345, 92);
            this.cbxType.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(120, 21);
            this.cbxType.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(138, 26);
            this.txtNumero.MaximumSize = new System.Drawing.Size(121, 20);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(120, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(284, 96);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type : ";
            // 
            // lblRaisonSocial
            // 
            this.lblRaisonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaisonSocial.AutoSize = true;
            this.lblRaisonSocial.Location = new System.Drawing.Point(12, 61);
            this.lblRaisonSocial.Name = "lblRaisonSocial";
            this.lblRaisonSocial.Size = new System.Drawing.Size(81, 13);
            this.lblRaisonSocial.TabIndex = 1;
            this.lblRaisonSocial.Text = "Raison Social : ";
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Location = new System.Drawing.Point(11, 30);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(78, 13);
            this.lblClientNumber.TabIndex = 0;
            this.lblClientNumber.Text = "Numéro client :";
            // 
            // tabIntervenant
            // 
            this.tabIntervenant.Controls.Add(this.flowLayoutPanel4);
            this.tabIntervenant.Location = new System.Drawing.Point(4, 22);
            this.tabIntervenant.Name = "tabIntervenant";
            this.tabIntervenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntervenant.Size = new System.Drawing.Size(804, 695);
            this.tabIntervenant.TabIndex = 1;
            this.tabIntervenant.Text = "Intervenants";
            this.tabIntervenant.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gpbClientInformation);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(794, 685);
            this.flowLayoutPanel2.TabIndex = 30;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(3, 461);
            this.btnEdit.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 22);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.button1);
            this.flowLayoutPanel4.Controls.Add(this.button2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(283, 211);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(302, 100);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormGrdClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 725);
            this.Controls.Add(this.splClient);
            this.Name = "FormGrdClient";
            this.Text = "FormGrdClient";
            this.Load += new System.EventHandler(this.FormGrdClient_Load);
            this.splClient.Panel1.ResumeLayout(false);
            this.splClient.Panel1.PerformLayout();
            this.splClient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splClient)).EndInit();
            this.splClient.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControlClient.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.gpbClientInformation.ResumeLayout(false);
            this.gpbClientInformation.PerformLayout();
            this.tabIntervenant.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splClient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabIntervenant;
        protected System.Windows.Forms.GroupBox gpbClientInformation;
        protected System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTown;
        protected System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        protected System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        protected System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label lblCommentaire;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEffectif;
        protected System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.Label lblChiffreAffaire;
        protected System.Windows.Forms.ComboBox cbxNature;
        private System.Windows.Forms.Label lblNature;
        protected System.Windows.Forms.ComboBox cbxActivity;
        private System.Windows.Forms.Label lblDomaine;
        protected System.Windows.Forms.TextBox txtRaisonSocial;
        protected System.Windows.Forms.ComboBox cbxType;
        protected System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRaisonSocial;
        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}