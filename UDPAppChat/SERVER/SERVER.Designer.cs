namespace SERVER
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
            this.lstBClientList = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.rTxtBMessageDisplay.Location = new System.Drawing.Point(344, 35);
            this.rTxtBMessageDisplay.Name = "rTxtBMessageDisplay";
            this.rTxtBMessageDisplay.Size = new System.Drawing.Size(1541, 922);
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
            // 
            // lstBClientList
            // 
            this.lstBClientList.FormattingEnabled = true;
            this.lstBClientList.ItemHeight = 20;
            this.lstBClientList.Location = new System.Drawing.Point(12, 33);
            this.lstBClientList.Name = "lstBClientList";
            this.lstBClientList.Size = new System.Drawing.Size(311, 924);
            this.lstBClientList.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 984);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(311, 53);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // SERVERForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1062);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lstBClientList);
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
        private System.Windows.Forms.ListBox lstBClientList;
        private System.Windows.Forms.Button btnCreate;
    }
}

