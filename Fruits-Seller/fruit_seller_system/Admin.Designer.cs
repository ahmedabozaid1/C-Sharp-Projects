namespace fruit_seller_system
{
    partial class Adminwindow
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.previousBT = new System.Windows.Forms.Button();
            this.nextBT = new System.Windows.Forms.Button();
            this.uploadimageBT = new System.Windows.Forms.Button();
            this.additemBT = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.colorTB = new System.Windows.Forms.TextBox();
            this.signinlabel = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.priceLB = new System.Windows.Forms.Label();
            this.colorLB = new System.Windows.Forms.Label();
            this.fruitnameLB = new System.Windows.Forms.Label();
            this.priceb = new System.Windows.Forms.Label();
            this.pricevalueLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // previousBT
            // 
            this.previousBT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.previousBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previousBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBT.Location = new System.Drawing.Point(240, 332);
            this.previousBT.Name = "previousBT";
            this.previousBT.Size = new System.Drawing.Size(100, 35);
            this.previousBT.TabIndex = 31;
            this.previousBT.Text = "Previous";
            this.previousBT.UseVisualStyleBackColor = false;
            this.previousBT.Click += new System.EventHandler(this.previousBT_Click);
            // 
            // nextBT
            // 
            this.nextBT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nextBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBT.Location = new System.Drawing.Point(480, 332);
            this.nextBT.Name = "nextBT";
            this.nextBT.Size = new System.Drawing.Size(100, 35);
            this.nextBT.TabIndex = 32;
            this.nextBT.Text = "Next";
            this.nextBT.UseVisualStyleBackColor = false;
            this.nextBT.Click += new System.EventHandler(this.nextBT_Click);
            // 
            // uploadimageBT
            // 
            this.uploadimageBT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uploadimageBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uploadimageBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadimageBT.Location = new System.Drawing.Point(344, 518);
            this.uploadimageBT.Name = "uploadimageBT";
            this.uploadimageBT.Size = new System.Drawing.Size(100, 35);
            this.uploadimageBT.TabIndex = 33;
            this.uploadimageBT.Text = "Upload Image";
            this.uploadimageBT.UseVisualStyleBackColor = false;
            this.uploadimageBT.Click += new System.EventHandler(this.uploadimageBT_Click);
            // 
            // additemBT
            // 
            this.additemBT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.additemBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.additemBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemBT.Location = new System.Drawing.Point(344, 559);
            this.additemBT.Name = "additemBT";
            this.additemBT.Size = new System.Drawing.Size(100, 35);
            this.additemBT.TabIndex = 34;
            this.additemBT.Text = "Add Item";
            this.additemBT.UseVisualStyleBackColor = false;
            this.additemBT.Click += new System.EventHandler(this.additemBT_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(344, 440);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 35;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(344, 466);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 36;
            // 
            // colorTB
            // 
            this.colorTB.Location = new System.Drawing.Point(344, 492);
            this.colorTB.Name = "colorTB";
            this.colorTB.Size = new System.Drawing.Size(100, 20);
            this.colorTB.TabIndex = 37;
            // 
            // signinlabel
            // 
            this.signinlabel.AutoSize = true;
            this.signinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinlabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signinlabel.Location = new System.Drawing.Point(280, 380);
            this.signinlabel.Name = "signinlabel";
            this.signinlabel.Size = new System.Drawing.Size(245, 39);
            this.signinlabel.TabIndex = 38;
            this.signinlabel.Text = "Add New Item";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.Location = new System.Drawing.Point(286, 440);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(52, 18);
            this.nameLB.TabIndex = 39;
            this.nameLB.Text = "Name";
            // 
            // priceLB
            // 
            this.priceLB.AutoSize = true;
            this.priceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLB.Location = new System.Drawing.Point(286, 468);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(47, 18);
            this.priceLB.TabIndex = 40;
            this.priceLB.Text = "Price";
            // 
            // colorLB
            // 
            this.colorLB.AutoSize = true;
            this.colorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLB.Location = new System.Drawing.Point(286, 494);
            this.colorLB.Name = "colorLB";
            this.colorLB.Size = new System.Drawing.Size(50, 18);
            this.colorLB.TabIndex = 41;
            this.colorLB.Text = "Color";
            // 
            // fruitnameLB
            // 
            this.fruitnameLB.AutoSize = true;
            this.fruitnameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitnameLB.Location = new System.Drawing.Point(373, 48);
            this.fruitnameLB.Name = "fruitnameLB";
            this.fruitnameLB.Size = new System.Drawing.Size(0, 16);
            this.fruitnameLB.TabIndex = 42;
            // 
            // priceb
            // 
            this.priceb.AutoSize = true;
            this.priceb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceb.Location = new System.Drawing.Point(360, 343);
            this.priceb.Name = "priceb";
            this.priceb.Size = new System.Drawing.Size(45, 18);
            this.priceb.TabIndex = 43;
            this.priceb.Text = "price";
            // 
            // pricevalueLB
            // 
            this.pricevalueLB.AutoSize = true;
            this.pricevalueLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricevalueLB.Location = new System.Drawing.Point(411, 343);
            this.pricevalueLB.Name = "pricevalueLB";
            this.pricevalueLB.Size = new System.Drawing.Size(0, 18);
            this.pricevalueLB.TabIndex = 44;
            // 
            // Adminwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 609);
            this.Controls.Add(this.pricevalueLB);
            this.Controls.Add(this.priceb);
            this.Controls.Add(this.fruitnameLB);
            this.Controls.Add(this.colorLB);
            this.Controls.Add(this.priceLB);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.signinlabel);
            this.Controls.Add(this.colorTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.additemBT);
            this.Controls.Add(this.uploadimageBT);
            this.Controls.Add(this.nextBT);
            this.Controls.Add(this.previousBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Adminwindow";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Adminwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button previousBT;
        private System.Windows.Forms.Button nextBT;
        private System.Windows.Forms.Button uploadimageBT;
        private System.Windows.Forms.Button additemBT;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox colorTB;
        private System.Windows.Forms.Label signinlabel;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label priceLB;
        private System.Windows.Forms.Label colorLB;
        private System.Windows.Forms.Label fruitnameLB;
        private System.Windows.Forms.Label priceb;
        private System.Windows.Forms.Label pricevalueLB;
    }
}