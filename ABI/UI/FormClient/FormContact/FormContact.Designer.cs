namespace ABI
{
    partial class FormContact
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
            this.gpxContactDetail = new System.Windows.Forms.GroupBox();
            this.txtContactTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtContactIdClient = new System.Windows.Forms.TextBox();
            this.lblIdContact = new System.Windows.Forms.Label();
            this.lblContactTelephone = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactFonction = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gpxContactDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxContactDetail
            // 
            this.gpxContactDetail.Controls.Add(this.txtContactTelephone);
            this.gpxContactDetail.Controls.Add(this.txtContactIdClient);
            this.gpxContactDetail.Controls.Add(this.lblIdContact);
            this.gpxContactDetail.Controls.Add(this.lblContactTelephone);
            this.gpxContactDetail.Controls.Add(this.txtContactEmail);
            this.gpxContactDetail.Controls.Add(this.lblContactEmail);
            this.gpxContactDetail.Controls.Add(this.txtContactFonction);
            this.gpxContactDetail.Controls.Add(this.txtContactName);
            this.gpxContactDetail.Controls.Add(this.lblContactType);
            this.gpxContactDetail.Controls.Add(this.lblContactName);
            this.gpxContactDetail.Location = new System.Drawing.Point(12, 12);
            this.gpxContactDetail.Name = "gpxContactDetail";
            this.gpxContactDetail.Size = new System.Drawing.Size(296, 153);
            this.gpxContactDetail.TabIndex = 0;
            this.gpxContactDetail.TabStop = false;
            this.gpxContactDetail.Text = "Detail";
            // 
            // txtContactTelephone
            // 
            this.txtContactTelephone.Location = new System.Drawing.Point(94, 124);
            this.txtContactTelephone.Mask = "00 00 00 00 00";
            this.txtContactTelephone.Name = "txtContactTelephone";
            this.txtContactTelephone.Size = new System.Drawing.Size(119, 20);
            this.txtContactTelephone.TabIndex = 4;
            this.txtContactTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContactTelephone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtContactTelephone_MaskInputRejected);
            // 
            // txtContactIdClient
            // 
            this.txtContactIdClient.Location = new System.Drawing.Point(93, 17);
            this.txtContactIdClient.Name = "txtContactIdClient";
            this.txtContactIdClient.ReadOnly = true;
            this.txtContactIdClient.Size = new System.Drawing.Size(121, 20);
            this.txtContactIdClient.TabIndex = 23;
            // 
            // lblIdContact
            // 
            this.lblIdContact.AutoSize = true;
            this.lblIdContact.Location = new System.Drawing.Point(23, 21);
            this.lblIdContact.Name = "lblIdContact";
            this.lblIdContact.Size = new System.Drawing.Size(62, 13);
            this.lblIdContact.TabIndex = 22;
            this.lblIdContact.Text = "Identifiant : ";
            // 
            // lblContactTelephone
            // 
            this.lblContactTelephone.AutoSize = true;
            this.lblContactTelephone.Location = new System.Drawing.Point(23, 124);
            this.lblContactTelephone.Name = "lblContactTelephone";
            this.lblContactTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblContactTelephone.TabIndex = 20;
            this.lblContactTelephone.Text = "Téléphone :";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(93, 95);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(181, 20);
            this.txtContactEmail.TabIndex = 3;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(23, 99);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(41, 13);
            this.lblContactEmail.TabIndex = 18;
            this.lblContactEmail.Text = "Email : ";
            // 
            // txtContactFonction
            // 
            this.txtContactFonction.Location = new System.Drawing.Point(93, 69);
            this.txtContactFonction.Name = "txtContactFonction";
            this.txtContactFonction.Size = new System.Drawing.Size(120, 20);
            this.txtContactFonction.TabIndex = 2;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(93, 43);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(121, 20);
            this.txtContactName.TabIndex = 1;
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Location = new System.Drawing.Point(24, 73);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(57, 13);
            this.lblContactType.TabIndex = 15;
            this.lblContactType.Text = "Fonction : ";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(23, 47);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(35, 13);
            this.lblContactName.TabIndex = 14;
            this.lblContactName.Text = "Nom :";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(103, 168);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(156, 16);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Un nom doit être précisé.";
            this.lblError.Visible = false;
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 190);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gpxContactDetail);
            this.Name = "FormContact";
            this.Text = "Contact";
            this.gpxContactDetail.ResumeLayout(false);
            this.gpxContactDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.GroupBox gpxContactDetail;
        protected System.Windows.Forms.TextBox txtContactFonction;
        protected System.Windows.Forms.TextBox txtContactName;
        protected System.Windows.Forms.TextBox txtContactEmail;
        protected System.Windows.Forms.TextBox txtContactIdClient;
        protected System.Windows.Forms.MaskedTextBox txtContactTelephone;
        protected System.Windows.Forms.Label lblContactEmail;
        protected System.Windows.Forms.Label lblContactType;
        protected System.Windows.Forms.Label lblContactName;
        protected System.Windows.Forms.Label lblContactTelephone;
        protected System.Windows.Forms.Label lblIdContact;
        protected System.Windows.Forms.Label lblError;
    }
}