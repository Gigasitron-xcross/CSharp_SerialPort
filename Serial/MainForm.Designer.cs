namespace Serial
{
    partial class MainForm
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
            this.cboxComport = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboxBaudrate = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tboxData = new System.Windows.Forms.TextBox();
            this.tboxReceive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboxComport
            // 
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(12, 12);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(121, 21);
            this.cboxComport.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(201, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboxBaudrate
            // 
            this.cboxBaudrate.FormattingEnabled = true;
            this.cboxBaudrate.Location = new System.Drawing.Point(12, 39);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cboxBaudrate.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(201, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(201, 200);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tboxData
            // 
            this.tboxData.Location = new System.Drawing.Point(12, 93);
            this.tboxData.Multiline = true;
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(264, 101);
            this.tboxData.TabIndex = 5;
            // 
            // tboxReceive
            // 
            this.tboxReceive.Location = new System.Drawing.Point(12, 241);
            this.tboxReceive.Multiline = true;
            this.tboxReceive.Name = "tboxReceive";
            this.tboxReceive.Size = new System.Drawing.Size(264, 101);
            this.tboxReceive.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.tboxReceive);
            this.Controls.Add(this.tboxData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboxBaudrate);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboxComport);
            this.Name = "MainForm";
            this.Text = "Serial V1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboxBaudrate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.TextBox tboxReceive;
    }
}

