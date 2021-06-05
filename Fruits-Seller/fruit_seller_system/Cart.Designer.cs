namespace fruit_seller_system
{
    partial class Cartwindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeBT = new System.Windows.Forms.Button();
            this.yourcartLB = new System.Windows.Forms.Label();
            this.totalLB = new System.Windows.Forms.Label();
            this.priceLB = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.fruitnamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // removeBT
            // 
            this.removeBT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.removeBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBT.Location = new System.Drawing.Point(417, 292);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(120, 35);
            this.removeBT.TabIndex = 37;
            this.removeBT.Text = "Remove";
            this.removeBT.UseVisualStyleBackColor = false;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // yourcartLB
            // 
            this.yourcartLB.AutoSize = true;
            this.yourcartLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourcartLB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.yourcartLB.Location = new System.Drawing.Point(203, 9);
            this.yourcartLB.Name = "yourcartLB";
            this.yourcartLB.Size = new System.Drawing.Size(174, 39);
            this.yourcartLB.TabIndex = 38;
            this.yourcartLB.Text = "Your Cart";
            // 
            // totalLB
            // 
            this.totalLB.AutoSize = true;
            this.totalLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalLB.Location = new System.Drawing.Point(5, 302);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(75, 33);
            this.totalLB.TabIndex = 39;
            this.totalLB.Text = "total";
            // 
            // priceLB
            // 
            this.priceLB.AutoSize = true;
            this.priceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.priceLB.Location = new System.Drawing.Point(90, 302);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(0, 33);
            this.priceLB.TabIndex = 40;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(417, 102);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 184);
            this.listBox.TabIndex = 41;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // fruitnamelabel
            // 
            this.fruitnamelabel.AutoSize = true;
            this.fruitnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitnamelabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fruitnamelabel.Location = new System.Drawing.Point(90, 57);
            this.fruitnamelabel.Name = "fruitnamelabel";
            this.fruitnamelabel.Size = new System.Drawing.Size(0, 33);
            this.fruitnamelabel.TabIndex = 42;
            // 
            // Cartwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 408);
            this.Controls.Add(this.fruitnamelabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.priceLB);
            this.Controls.Add(this.totalLB);
            this.Controls.Add(this.yourcartLB);
            this.Controls.Add(this.removeBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cartwindow";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cartwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button removeBT;
        private System.Windows.Forms.Label yourcartLB;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.Label priceLB;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label fruitnamelabel;
    }
}