namespace ButtonCounter
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
            this.btclick = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.lbcounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btclick
            // 
            this.btclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btclick.Location = new System.Drawing.Point(72, 131);
            this.btclick.Name = "btclick";
            this.btclick.Size = new System.Drawing.Size(95, 42);
            this.btclick.TabIndex = 0;
            this.btclick.Text = "Click";
            this.btclick.UseVisualStyleBackColor = true;
            this.btclick.Click += new System.EventHandler(this.btclick_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btreset.Location = new System.Drawing.Point(264, 131);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(95, 42);
            this.btreset.TabIndex = 1;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // lbcounter
            // 
            this.lbcounter.AutoSize = true;
            this.lbcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbcounter.Location = new System.Drawing.Point(163, 64);
            this.lbcounter.Name = "lbcounter";
            this.lbcounter.Size = new System.Drawing.Size(82, 24);
            this.lbcounter.TabIndex = 2;
            this.lbcounter.Text = "Counter:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.lbcounter);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btclick);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Button Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btclick;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Label lbcounter;
    }
}

