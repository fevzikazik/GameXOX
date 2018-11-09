namespace GameXOX
{
    partial class frmGirisAyar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbOnNetwork = new System.Windows.Forms.RadioButton();
            this.rdbPlayerVsComputer = new System.Windows.Forms.RadioButton();
            this.rdbPlayerVsPlayer = new System.Windows.Forms.RadioButton();
            this.btnModuSec = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbOnNetwork);
            this.groupBox2.Controls.Add(this.rdbPlayerVsComputer);
            this.groupBox2.Controls.Add(this.rdbPlayerVsPlayer);
            this.groupBox2.Controls.Add(this.btnModuSec);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(199, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyun Ayarları";
            // 
            // rdbOnNetwork
            // 
            this.rdbOnNetwork.AutoSize = true;
            this.rdbOnNetwork.Location = new System.Drawing.Point(23, 74);
            this.rdbOnNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.rdbOnNetwork.Name = "rdbOnNetwork";
            this.rdbOnNetwork.Size = new System.Drawing.Size(116, 17);
            this.rdbOnNetwork.TabIndex = 5;
            this.rdbOnNetwork.TabStop = true;
            this.rdbOnNetwork.Text = "Network Üzerinden";
            this.rdbOnNetwork.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerVsComputer
            // 
            this.rdbPlayerVsComputer.AutoSize = true;
            this.rdbPlayerVsComputer.Location = new System.Drawing.Point(23, 52);
            this.rdbPlayerVsComputer.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPlayerVsComputer.Name = "rdbPlayerVsComputer";
            this.rdbPlayerVsComputer.Size = new System.Drawing.Size(101, 17);
            this.rdbPlayerVsComputer.TabIndex = 4;
            this.rdbPlayerVsComputer.TabStop = true;
            this.rdbPlayerVsComputer.Text = "Bilgisayara Karşı";
            this.rdbPlayerVsComputer.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerVsPlayer
            // 
            this.rdbPlayerVsPlayer.AutoSize = true;
            this.rdbPlayerVsPlayer.Location = new System.Drawing.Point(23, 30);
            this.rdbPlayerVsPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPlayerVsPlayer.Name = "rdbPlayerVsPlayer";
            this.rdbPlayerVsPlayer.Size = new System.Drawing.Size(150, 17);
            this.rdbPlayerVsPlayer.TabIndex = 3;
            this.rdbPlayerVsPlayer.TabStop = true;
            this.rdbPlayerVsPlayer.Text = "Aynı Bilgisayardan Karşılıklı";
            this.rdbPlayerVsPlayer.UseVisualStyleBackColor = true;
            // 
            // btnModuSec
            // 
            this.btnModuSec.Location = new System.Drawing.Point(23, 107);
            this.btnModuSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnModuSec.Name = "btnModuSec";
            this.btnModuSec.Size = new System.Drawing.Size(148, 26);
            this.btnModuSec.TabIndex = 2;
            this.btnModuSec.Text = "Oyun Başlat";
            this.btnModuSec.UseVisualStyleBackColor = true;
            this.btnModuSec.Click += new System.EventHandler(this.btnOyunModu_Click);
            // 
            // frmGirisAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 173);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGirisAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameXOX";
            this.Load += new System.EventHandler(this.frmGirisAyar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbOnNetwork;
        private System.Windows.Forms.RadioButton rdbPlayerVsComputer;
        private System.Windows.Forms.RadioButton rdbPlayerVsPlayer;
        private System.Windows.Forms.Button btnModuSec;
    }
}

