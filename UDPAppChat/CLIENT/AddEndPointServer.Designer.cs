namespace CLIENT
{
    partial class AddEndPointServer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBPort = new System.Windows.Forms.TextBox();
            this.txtBIPAddress = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIPaddress = new System.Windows.Forms.Label();
            this.btnAddEndPont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 72);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBPort
            // 
            this.txtBPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPort.Location = new System.Drawing.Point(287, 198);
            this.txtBPort.Name = "txtBPort";
            this.txtBPort.Size = new System.Drawing.Size(308, 41);
            this.txtBPort.TabIndex = 10;
            // 
            // txtBIPAddress
            // 
            this.txtBIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIPAddress.Location = new System.Drawing.Point(287, 74);
            this.txtBIPAddress.Name = "txtBIPAddress";
            this.txtBIPAddress.Size = new System.Drawing.Size(308, 41);
            this.txtBIPAddress.TabIndex = 9;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(45, 203);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(97, 36);
            this.lbPort.TabIndex = 8;
            this.lbPort.Text = "PORT";
            // 
            // lbIPaddress
            // 
            this.lbIPaddress.AutoSize = true;
            this.lbIPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPaddress.Location = new System.Drawing.Point(45, 79);
            this.lbIPaddress.Name = "lbIPaddress";
            this.lbIPaddress.Size = new System.Drawing.Size(196, 36);
            this.lbIPaddress.TabIndex = 7;
            this.lbIPaddress.Text = "IP ADDRESS";
            // 
            // btnAddEndPont
            // 
            this.btnAddEndPont.Location = new System.Drawing.Point(477, 324);
            this.btnAddEndPont.Name = "btnAddEndPont";
            this.btnAddEndPont.Size = new System.Drawing.Size(209, 72);
            this.btnAddEndPont.TabIndex = 6;
            this.btnAddEndPont.Text = "ADD";
            this.btnAddEndPont.UseVisualStyleBackColor = true;
            this.btnAddEndPont.Click += new System.EventHandler(this.btnAddEndPont_Click);
            // 
            // AddEndPointServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 436);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBPort);
            this.Controls.Add(this.txtBIPAddress);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIPaddress);
            this.Controls.Add(this.btnAddEndPont);
            this.Name = "AddEndPointServer";
            this.Text = "ADD END POINT SERVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBPort;
        private System.Windows.Forms.TextBox txtBIPAddress;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIPaddress;
        private System.Windows.Forms.Button btnAddEndPont;
    }
}