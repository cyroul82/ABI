﻿namespace ABI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblContactTelephone = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactType = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblIdContact = new System.Windows.Forms.Label();
            this.gpxContactDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxContactDetail
            // 
            this.gpxContactDetail.Controls.Add(this.textBox2);
            this.gpxContactDetail.Controls.Add(this.lblIdContact);
            this.gpxContactDetail.Controls.Add(this.textBox1);
            this.gpxContactDetail.Controls.Add(this.lblContactTelephone);
            this.gpxContactDetail.Controls.Add(this.txtContactEmail);
            this.gpxContactDetail.Controls.Add(this.lblContactEmail);
            this.gpxContactDetail.Controls.Add(this.txtContactType);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 21;
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
            this.txtContactEmail.TabIndex = 19;
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
            // txtContactType
            // 
            this.txtContactType.Location = new System.Drawing.Point(93, 69);
            this.txtContactType.Name = "txtContactType";
            this.txtContactType.Size = new System.Drawing.Size(120, 20);
            this.txtContactType.TabIndex = 17;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(93, 43);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(121, 20);
            this.txtContactName.TabIndex = 16;
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Location = new System.Drawing.Point(24, 73);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(40, 13);
            this.lblContactType.TabIndex = 15;
            this.lblContactType.Text = "Type : ";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 23;
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
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 183);
            this.Controls.Add(this.gpxContactDetail);
            this.Name = "FormContact";
            this.Text = "Contact";
            this.gpxContactDetail.ResumeLayout(false);
            this.gpxContactDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxContactDetail;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.TextBox txtContactType;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblContactTelephone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblIdContact;
    }
}