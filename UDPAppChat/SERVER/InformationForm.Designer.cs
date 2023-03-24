namespace SERVER
{
    partial class InformationForm
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
            this.txtBPort = new System.Windows.Forms.TextBox();
            this.txtBIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIPaddress = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBPort
            // 
            this.txtBPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPort.Location = new System.Drawing.Point(287, 200);
            this.txtBPort.Name = "txtBPort";
            this.txtBPort.Size = new System.Drawing.Size(308, 41);
            this.txtBPort.TabIndex = 8;
            // 
            // txtBIPAddress
            // 
            this.txtBIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIPAddress.Location = new System.Drawing.Point(287, 76);
            this.txtBIPAddress.Name = "txtBIPAddress";
            this.txtBIPAddress.Size = new System.Drawing.Size(308, 41);
            this.txtBIPAddress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "PORT";
            // 
            // lbIPaddress
            // 
            this.lbIPaddress.AutoSize = true;
            this.lbIPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPaddress.Location = new System.Drawing.Point(45, 81);
            this.lbIPaddress.Name = "lbIPaddress";
            this.lbIPaddress.Size = new System.Drawing.Size(196, 36);
            this.lbIPaddress.TabIndex = 5;
            this.lbIPaddress.Text = "IP ADDRESS";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(228, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(209, 72);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 388);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBPort);
            this.Controls.Add(this.txtBIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIPaddress);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBPort;
        private System.Windows.Forms.TextBox txtBIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIPaddress;
        private System.Windows.Forms.Button btnOK;
    }
}