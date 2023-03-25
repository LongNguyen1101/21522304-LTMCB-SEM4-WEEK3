namespace SERVER
{
    partial class CreateForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbIPaddress = new System.Windows.Forms.Label();
            this.lbLocalPort = new System.Windows.Forms.Label();
            this.txtBIPAddress = new System.Windows.Forms.TextBox();
            this.txtBLocalPort = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBRemotePort = new System.Windows.Forms.TextBox();
            this.lbRemotePort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(477, 324);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(209, 72);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbIPaddress
            // 
            this.lbIPaddress.AutoSize = true;
            this.lbIPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPaddress.Location = new System.Drawing.Point(45, 79);
            this.lbIPaddress.Name = "lbIPaddress";
            this.lbIPaddress.Size = new System.Drawing.Size(196, 36);
            this.lbIPaddress.TabIndex = 1;
            this.lbIPaddress.Text = "IP ADDRESS";
            // 
            // lbLocalPort
            // 
            this.lbLocalPort.AutoSize = true;
            this.lbLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalPort.Location = new System.Drawing.Point(45, 149);
            this.lbLocalPort.Name = "lbLocalPort";
            this.lbLocalPort.Size = new System.Drawing.Size(203, 36);
            this.lbLocalPort.TabIndex = 2;
            this.lbLocalPort.Text = "LOCAL PORT";
            // 
            // txtBIPAddress
            // 
            this.txtBIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIPAddress.Location = new System.Drawing.Point(287, 74);
            this.txtBIPAddress.Name = "txtBIPAddress";
            this.txtBIPAddress.Size = new System.Drawing.Size(308, 41);
            this.txtBIPAddress.TabIndex = 3;
            // 
            // txtBLocalPort
            // 
            this.txtBLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBLocalPort.Location = new System.Drawing.Point(287, 144);
            this.txtBLocalPort.Name = "txtBLocalPort";
            this.txtBLocalPort.Size = new System.Drawing.Size(308, 41);
            this.txtBLocalPort.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 72);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBRemotePort
            // 
            this.txtBRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBRemotePort.Location = new System.Drawing.Point(287, 218);
            this.txtBRemotePort.Name = "txtBRemotePort";
            this.txtBRemotePort.Size = new System.Drawing.Size(308, 41);
            this.txtBRemotePort.TabIndex = 15;
            // 
            // lbRemotePort
            // 
            this.lbRemotePort.AutoSize = true;
            this.lbRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemotePort.Location = new System.Drawing.Point(45, 223);
            this.lbRemotePort.Name = "lbRemotePort";
            this.lbRemotePort.Size = new System.Drawing.Size(232, 36);
            this.lbRemotePort.TabIndex = 14;
            this.lbRemotePort.Text = "REMOTE PORT";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 436);
            this.Controls.Add(this.txtBRemotePort);
            this.Controls.Add(this.lbRemotePort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBLocalPort);
            this.Controls.Add(this.txtBIPAddress);
            this.Controls.Add(this.lbLocalPort);
            this.Controls.Add(this.lbIPaddress);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateForm";
            this.Text = "ADD END POINT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lbIPaddress;
        private System.Windows.Forms.Label lbLocalPort;
        private System.Windows.Forms.TextBox txtBIPAddress;
        private System.Windows.Forms.TextBox txtBLocalPort;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBRemotePort;
        private System.Windows.Forms.Label lbRemotePort;
    }
}