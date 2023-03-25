namespace CLIENT
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
            this.txtBRemotePort = new System.Windows.Forms.TextBox();
            this.lbRemotePort = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBLocalPort = new System.Windows.Forms.TextBox();
            this.txtBIPAddress = new System.Windows.Forms.TextBox();
            this.lbLocalPort = new System.Windows.Forms.Label();
            this.lbIPaddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBRemotePort
            // 
            this.txtBRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBRemotePort.Location = new System.Drawing.Point(296, 185);
            this.txtBRemotePort.Name = "txtBRemotePort";
            this.txtBRemotePort.Size = new System.Drawing.Size(308, 41);
            this.txtBRemotePort.TabIndex = 24;
            // 
            // lbRemotePort
            // 
            this.lbRemotePort.AutoSize = true;
            this.lbRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemotePort.Location = new System.Drawing.Point(54, 190);
            this.lbRemotePort.Name = "lbRemotePort";
            this.lbRemotePort.Size = new System.Drawing.Size(232, 36);
            this.lbRemotePort.TabIndex = 23;
            this.lbRemotePort.Text = "REMOTE PORT";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(228, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(209, 72);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBLocalPort
            // 
            this.txtBLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBLocalPort.Location = new System.Drawing.Point(296, 118);
            this.txtBLocalPort.Name = "txtBLocalPort";
            this.txtBLocalPort.Size = new System.Drawing.Size(308, 41);
            this.txtBLocalPort.TabIndex = 21;
            // 
            // txtBIPAddress
            // 
            this.txtBIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIPAddress.Location = new System.Drawing.Point(296, 52);
            this.txtBIPAddress.Name = "txtBIPAddress";
            this.txtBIPAddress.Size = new System.Drawing.Size(308, 41);
            this.txtBIPAddress.TabIndex = 20;
            // 
            // lbLocalPort
            // 
            this.lbLocalPort.AutoSize = true;
            this.lbLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalPort.Location = new System.Drawing.Point(54, 123);
            this.lbLocalPort.Name = "lbLocalPort";
            this.lbLocalPort.Size = new System.Drawing.Size(203, 36);
            this.lbLocalPort.TabIndex = 19;
            this.lbLocalPort.Text = "LOCAL PORT";
            // 
            // lbIPaddress
            // 
            this.lbIPaddress.AutoSize = true;
            this.lbIPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPaddress.Location = new System.Drawing.Point(54, 57);
            this.lbIPaddress.Name = "lbIPaddress";
            this.lbIPaddress.Size = new System.Drawing.Size(196, 36);
            this.lbIPaddress.TabIndex = 18;
            this.lbIPaddress.Text = "IP ADDRESS";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 388);
            this.Controls.Add(this.txtBRemotePort);
            this.Controls.Add(this.lbRemotePort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBLocalPort);
            this.Controls.Add(this.txtBIPAddress);
            this.Controls.Add(this.lbLocalPort);
            this.Controls.Add(this.lbIPaddress);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBRemotePort;
        private System.Windows.Forms.Label lbRemotePort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtBLocalPort;
        private System.Windows.Forms.TextBox txtBIPAddress;
        private System.Windows.Forms.Label lbLocalPort;
        private System.Windows.Forms.Label lbIPaddress;
    }
}