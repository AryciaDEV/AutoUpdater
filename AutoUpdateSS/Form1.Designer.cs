namespace autoUpdate
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.lbheader = new System.Windows.Forms.Label();
            this.labelcurrent = new System.Windows.Forms.Label();
            this.labelnew = new System.Windows.Forms.Label();
            this.lbcurrent = new System.Windows.Forms.Label();
            this.lbnew = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bw_updateChecker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(113)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.pboxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 40);
            this.panel1.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Exit.Location = new System.Drawing.Point(535, 4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(32, 32);
            this.button_Exit.TabIndex = 15;
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxLogo.BackgroundImage")));
            this.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLogo.Location = new System.Drawing.Point(3, 5);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(140, 30);
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            // 
            // lbheader
            // 
            this.lbheader.AutoSize = true;
            this.lbheader.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbheader.Location = new System.Drawing.Point(124, 70);
            this.lbheader.Name = "lbheader";
            this.lbheader.Size = new System.Drawing.Size(321, 74);
            this.lbheader.TabIndex = 1;
            this.lbheader.Text = "A new version is available.\r\nDo you want to update?\r\n";
            // 
            // labelcurrent
            // 
            this.labelcurrent.AutoSize = true;
            this.labelcurrent.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelcurrent.Location = new System.Drawing.Point(39, 191);
            this.labelcurrent.Name = "labelcurrent";
            this.labelcurrent.Size = new System.Drawing.Size(183, 37);
            this.labelcurrent.TabIndex = 2;
            this.labelcurrent.Text = "Current Version:";
            // 
            // labelnew
            // 
            this.labelnew.AutoSize = true;
            this.labelnew.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelnew.Location = new System.Drawing.Point(73, 239);
            this.labelnew.Name = "labelnew";
            this.labelnew.Size = new System.Drawing.Size(149, 37);
            this.labelnew.TabIndex = 3;
            this.labelnew.Text = "New Version:";
            // 
            // lbcurrent
            // 
            this.lbcurrent.AutoSize = true;
            this.lbcurrent.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbcurrent.Location = new System.Drawing.Point(228, 191);
            this.lbcurrent.Name = "lbcurrent";
            this.lbcurrent.Size = new System.Drawing.Size(65, 37);
            this.lbcurrent.TabIndex = 4;
            this.lbcurrent.Text = "1.0.0";
            // 
            // lbnew
            // 
            this.lbnew.AutoSize = true;
            this.lbnew.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbnew.Location = new System.Drawing.Point(228, 239);
            this.lbnew.Name = "lbnew";
            this.lbnew.Size = new System.Drawing.Size(65, 37);
            this.lbnew.TabIndex = 5;
            this.lbnew.Text = "1.0.0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(378, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 85);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Now";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 370);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbnew);
            this.Controls.Add(this.lbcurrent);
            this.Controls.Add(this.labelnew);
            this.Controls.Add(this.labelcurrent);
            this.Controls.Add(this.lbheader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label lbheader;
        private System.Windows.Forms.Label labelcurrent;
        private System.Windows.Forms.Label labelnew;
        private System.Windows.Forms.Label lbcurrent;
        private System.Windows.Forms.Label lbnew;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker bw_updateChecker;
    }
}

