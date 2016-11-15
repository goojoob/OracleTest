namespace OracleTest
{
    partial class Form1
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
            this.btnTestOracle = new System.Windows.Forms.Button();
            this.lblResultTest = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestOracle
            // 
            this.btnTestOracle.Location = new System.Drawing.Point(16, 142);
            this.btnTestOracle.Name = "btnTestOracle";
            this.btnTestOracle.Size = new System.Drawing.Size(149, 23);
            this.btnTestOracle.TabIndex = 0;
            this.btnTestOracle.Text = "Test Oracle Connection";
            this.btnTestOracle.UseVisualStyleBackColor = true;
            this.btnTestOracle.Click += new System.EventHandler(this.btnTestOracle_Click);
            // 
            // lblResultTest
            // 
            this.lblResultTest.AutoSize = true;
            this.lblResultTest.Location = new System.Drawing.Point(13, 168);
            this.lblResultTest.Name = "lblResultTest";
            this.lblResultTest.Size = new System.Drawing.Size(95, 13);
            this.lblResultTest.TabIndex = 1;
            this.lblResultTest.Text = "Oracle Test Result";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(16, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(149, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "Oracle Host IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(16, 38);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(149, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "Oracle Host Port";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(16, 64);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(149, 20);
            this.txtService.TabIndex = 4;
            this.txtService.Text = "Oracle Service";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(16, 90);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "Scheme User";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(16, 116);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(149, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "Scheme Pass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 193);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblResultTest);
            this.Controls.Add(this.btnTestOracle);
            this.Name = "Form1";
            this.Text = "Oracle Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestOracle;
        private System.Windows.Forms.Label lblResultTest;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
    }
}

