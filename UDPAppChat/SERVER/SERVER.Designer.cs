﻿namespace SERVER
{
    partial class SERVERForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.rTxtBMessageDisplay = new System.Windows.Forms.RichTextBox();
            this.txtBMessageSend = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1761, 984);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 53);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rTxtBMessageDisplay
            // 
            this.rTxtBMessageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBMessageDisplay.Location = new System.Drawing.Point(29, 35);
            this.rTxtBMessageDisplay.Name = "rTxtBMessageDisplay";
            this.rTxtBMessageDisplay.Size = new System.Drawing.Size(1856, 922);
            this.rTxtBMessageDisplay.TabIndex = 2;
            this.rTxtBMessageDisplay.Text = "";
            // 
            // txtBMessageSend
            // 
            this.txtBMessageSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMessageSend.Location = new System.Drawing.Point(344, 984);
            this.txtBMessageSend.Name = "txtBMessageSend";
            this.txtBMessageSend.Size = new System.Drawing.Size(1396, 53);
            this.txtBMessageSend.TabIndex = 3;
            this.txtBMessageSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBMessageSend_KeyDown);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 984);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(147, 53);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(182, 984);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(147, 53);
            this.btnInformation.TabIndex = 6;
            this.btnInformation.Text = "INFORMATION";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // SERVERForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1062);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBMessageSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rTxtBMessageDisplay);
            this.Name = "SERVERForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SERVERForm_FormClosing);
            this.Load += new System.EventHandler(this.SERVERForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rTxtBMessageDisplay;
        private System.Windows.Forms.TextBox txtBMessageSend;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnInformation;
    }
}

