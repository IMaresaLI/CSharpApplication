
namespace FileManager
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
            this.fileCbx = new System.Windows.Forms.ComboBox();
            this.uzantıCbx = new System.Windows.Forms.ComboBox();
            this.CountFileTbx = new System.Windows.Forms.TextBox();
            this.TextTbx = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FileInfoTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileCbx
            // 
            this.fileCbx.FormattingEnabled = true;
            this.fileCbx.Location = new System.Drawing.Point(12, 12);
            this.fileCbx.Name = "fileCbx";
            this.fileCbx.Size = new System.Drawing.Size(121, 21);
            this.fileCbx.TabIndex = 0;
            // 
            // uzantıCbx
            // 
            this.uzantıCbx.FormattingEnabled = true;
            this.uzantıCbx.Items.AddRange(new object[] {
            "GetAll",
            ".py",
            ".exe",
            ".dart",
            ".json",
            ".php",
            ".html",
            ".css"});
            this.uzantıCbx.Location = new System.Drawing.Point(148, 12);
            this.uzantıCbx.Name = "uzantıCbx";
            this.uzantıCbx.Size = new System.Drawing.Size(121, 21);
            this.uzantıCbx.TabIndex = 1;
            this.uzantıCbx.Text = "GetAll";
            // 
            // CountFileTbx
            // 
            this.CountFileTbx.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CountFileTbx.Location = new System.Drawing.Point(294, 12);
            this.CountFileTbx.Name = "CountFileTbx";
            this.CountFileTbx.ReadOnly = true;
            this.CountFileTbx.Size = new System.Drawing.Size(87, 20);
            this.CountFileTbx.TabIndex = 1;
            this.CountFileTbx.Text = "Count";
            // 
            // TextTbx
            // 
            this.TextTbx.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextTbx.Location = new System.Drawing.Point(410, 12);
            this.TextTbx.Name = "TextTbx";
            this.TextTbx.Size = new System.Drawing.Size(130, 20);
            this.TextTbx.TabIndex = 1;
            this.TextTbx.Text = "Search";
            this.TextTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextTbx_MouseClick);
            this.TextTbx.Leave += new System.EventHandler(this.TextTbx_Leave);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(566, 10);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(629, 316);
            this.listBox1.TabIndex = 3;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // FileInfoTbx
            // 
            this.FileInfoTbx.AcceptsReturn = true;
            this.FileInfoTbx.AcceptsTab = true;
            this.FileInfoTbx.Location = new System.Drawing.Point(12, 377);
            this.FileInfoTbx.Multiline = true;
            this.FileInfoTbx.Name = "FileInfoTbx";
            this.FileInfoTbx.ReadOnly = true;
            this.FileInfoTbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileInfoTbx.Size = new System.Drawing.Size(629, 101);
            this.FileInfoTbx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 492);
            this.Controls.Add(this.FileInfoTbx);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.TextTbx);
            this.Controls.Add(this.CountFileTbx);
            this.Controls.Add(this.uzantıCbx);
            this.Controls.Add(this.fileCbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fileCbx;
        private System.Windows.Forms.ComboBox uzantıCbx;
        private System.Windows.Forms.TextBox CountFileTbx;
        private System.Windows.Forms.TextBox TextTbx;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox FileInfoTbx;
    }
}

