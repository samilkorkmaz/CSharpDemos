namespace UDPClientAndServer
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
            this.btSend = new System.Windows.Forms.Button();
            this.tbMessageSend = new System.Windows.Forms.TextBox();
            this.lbMessageReceived = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPortListen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbIpSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPortSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(12, 160);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbMessageSend
            // 
            this.tbMessageSend.Location = new System.Drawing.Point(12, 134);
            this.tbMessageSend.Name = "tbMessageSend";
            this.tbMessageSend.Size = new System.Drawing.Size(278, 20);
            this.tbMessageSend.TabIndex = 1;
            this.tbMessageSend.Text = "Hi from UDP client";
            // 
            // lbMessageReceived
            // 
            this.lbMessageReceived.AutoSize = true;
            this.lbMessageReceived.Location = new System.Drawing.Point(12, 198);
            this.lbMessageReceived.Name = "lbMessageReceived";
            this.lbMessageReceived.Size = new System.Drawing.Size(97, 13);
            this.lbMessageReceived.TabIndex = 3;
            this.lbMessageReceived.Text = "Message received:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port:";
            // 
            // tbPortListen
            // 
            this.tbPortListen.Location = new System.Drawing.Point(44, 22);
            this.tbPortListen.Name = "tbPortListen";
            this.tbPortListen.Size = new System.Drawing.Size(76, 20);
            this.tbPortListen.TabIndex = 5;
            this.tbPortListen.Text = "13001";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPortListen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbIpSend);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbPortSend);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(155, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 75);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // tbIpSend
            // 
            this.tbIpSend.Location = new System.Drawing.Point(45, 19);
            this.tbIpSend.Name = "tbIpSend";
            this.tbIpSend.Size = new System.Drawing.Size(76, 20);
            this.tbIpSend.TabIndex = 7;
            this.tbIpSend.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ip:";
            // 
            // tbPortSend
            // 
            this.tbPortSend.Location = new System.Drawing.Point(45, 45);
            this.tbPortSend.Name = "tbPortSend";
            this.tbPortSend.Size = new System.Drawing.Size(76, 20);
            this.tbPortSend.TabIndex = 5;
            this.tbPortSend.Text = "13002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port:";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(15, 93);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 227);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMessageReceived);
            this.Controls.Add(this.tbMessageSend);
            this.Controls.Add(this.btSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UDP Client & Server - Dec 2017";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbMessageSend;
        private System.Windows.Forms.Label lbMessageReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPortListen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbIpSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPortSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btConnect;
    }
}

