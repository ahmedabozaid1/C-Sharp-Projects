namespace Disk_Scheduling
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FCFSbt = new System.Windows.Forms.Button();
            this.SSTFbt = new System.Windows.Forms.Button();
            this.Scanbt = new System.Windows.Forms.Button();
            this.CSCANbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disk Scheduling";
            // 
            // FCFSbt
            // 
            this.FCFSbt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FCFSbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FCFSbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFSbt.Location = new System.Drawing.Point(255, 246);
            this.FCFSbt.Name = "FCFSbt";
            this.FCFSbt.Size = new System.Drawing.Size(114, 42);
            this.FCFSbt.TabIndex = 8;
            this.FCFSbt.Text = "FCFS";
            this.FCFSbt.UseVisualStyleBackColor = false;
            this.FCFSbt.Click += new System.EventHandler(this.FCFSbt_Click);
            // 
            // SSTFbt
            // 
            this.SSTFbt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SSTFbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SSTFbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSTFbt.Location = new System.Drawing.Point(415, 246);
            this.SSTFbt.Name = "SSTFbt";
            this.SSTFbt.Size = new System.Drawing.Size(114, 42);
            this.SSTFbt.TabIndex = 9;
            this.SSTFbt.Text = "SSTF";
            this.SSTFbt.UseVisualStyleBackColor = false;
            this.SSTFbt.Click += new System.EventHandler(this.SSTFbt_Click);
            // 
            // Scanbt
            // 
            this.Scanbt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Scanbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Scanbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanbt.Location = new System.Drawing.Point(255, 313);
            this.Scanbt.Name = "Scanbt";
            this.Scanbt.Size = new System.Drawing.Size(114, 42);
            this.Scanbt.TabIndex = 10;
            this.Scanbt.Text = "SCAN";
            this.Scanbt.UseVisualStyleBackColor = false;
            this.Scanbt.Click += new System.EventHandler(this.Scanbt_Click);
            // 
            // CSCANbt
            // 
            this.CSCANbt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CSCANbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CSCANbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSCANbt.Location = new System.Drawing.Point(415, 313);
            this.CSCANbt.Name = "CSCANbt";
            this.CSCANbt.Size = new System.Drawing.Size(114, 42);
            this.CSCANbt.TabIndex = 11;
            this.CSCANbt.Text = "CSCAN";
            this.CSCANbt.UseVisualStyleBackColor = false;
            this.CSCANbt.Click += new System.EventHandler(this.CSCANbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CSCANbt);
            this.Controls.Add(this.Scanbt);
            this.Controls.Add(this.SSTFbt);
            this.Controls.Add(this.FCFSbt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Disk Scheduling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FCFSbt;
        private System.Windows.Forms.Button SSTFbt;
        private System.Windows.Forms.Button Scanbt;
        private System.Windows.Forms.Button CSCANbt;
    }
}

