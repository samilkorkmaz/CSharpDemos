namespace TransparentDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbFront = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.cbHightlight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFront
            // 
            this.pbFront.Image = ((System.Drawing.Image)(resources.GetObject("pbFront.Image")));
            this.pbFront.InitialImage = null;
            this.pbFront.Location = new System.Drawing.Point(12, 12);
            this.pbFront.Name = "pbFront";
            this.pbFront.Size = new System.Drawing.Size(1157, 655);
            this.pbFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFront.TabIndex = 0;
            this.pbFront.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.InitialImage = null;
            this.pbBack.Location = new System.Drawing.Point(2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(1157, 656);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBack.TabIndex = 1;
            this.pbBack.TabStop = false;
            // 
            // cbHightlight
            // 
            this.cbHightlight.AutoSize = true;
            this.cbHightlight.Checked = true;
            this.cbHightlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHightlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHightlight.Location = new System.Drawing.Point(156, 84);
            this.cbHightlight.Name = "cbHightlight";
            this.cbHightlight.Size = new System.Drawing.Size(191, 48);
            this.cbHightlight.TabIndex = 2;
            this.cbHightlight.Text = "Highlight";
            this.cbHightlight.UseVisualStyleBackColor = true;
            this.cbHightlight.CheckedChanged += new System.EventHandler(this.cbHightlight_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 753);
            this.Controls.Add(this.cbHightlight);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbFront);
            this.Name = "Form1";
            this.Text = "Transparency Demo - Nov 2017";
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFront;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.CheckBox cbHightlight;
    }
}

