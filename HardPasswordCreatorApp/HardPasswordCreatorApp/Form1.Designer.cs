
namespace HardPasswordCreatorApp
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
            this.PasswordTypeGrpBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LetterRbtn = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.NumberRBtn = new System.Windows.Forms.RadioButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.BothRBtn = new System.Windows.Forms.RadioButton();
            this.SpecialCbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChLenghtTbx = new System.Windows.Forms.TextBox();
            this.PwTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.CreatePwBtn = new System.Windows.Forms.Button();
            this.PasswordTypeGrpBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTypeGrpBox
            // 
            this.PasswordTypeGrpBox.Controls.Add(this.flowLayoutPanel1);
            this.PasswordTypeGrpBox.Location = new System.Drawing.Point(13, 13);
            this.PasswordTypeGrpBox.Name = "PasswordTypeGrpBox";
            this.PasswordTypeGrpBox.Size = new System.Drawing.Size(415, 50);
            this.PasswordTypeGrpBox.TabIndex = 0;
            this.PasswordTypeGrpBox.TabStop = false;
            this.PasswordTypeGrpBox.Text = "Password Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.LetterRbtn);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.NumberRBtn);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.BothRBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LetterRbtn
            // 
            this.LetterRbtn.AutoSize = true;
            this.LetterRbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LetterRbtn.Location = new System.Drawing.Point(3, 3);
            this.LetterRbtn.Name = "LetterRbtn";
            this.LetterRbtn.Size = new System.Drawing.Size(76, 17);
            this.LetterRbtn.TabIndex = 0;
            this.LetterRbtn.TabStop = true;
            this.LetterRbtn.Text = "Only Letter";
            this.LetterRbtn.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(85, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(59, 17);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // NumberRBtn
            // 
            this.NumberRBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberRBtn.Location = new System.Drawing.Point(150, 3);
            this.NumberRBtn.Name = "NumberRBtn";
            this.NumberRBtn.Size = new System.Drawing.Size(104, 17);
            this.NumberRBtn.TabIndex = 1;
            this.NumberRBtn.TabStop = true;
            this.NumberRBtn.Text = "Only Number";
            this.NumberRBtn.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(260, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(64, 17);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // BothRBtn
            // 
            this.BothRBtn.AutoSize = true;
            this.BothRBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BothRBtn.Location = new System.Drawing.Point(330, 3);
            this.BothRBtn.Name = "BothRBtn";
            this.BothRBtn.Size = new System.Drawing.Size(47, 17);
            this.BothRBtn.TabIndex = 2;
            this.BothRBtn.TabStop = true;
            this.BothRBtn.Text = "Both";
            this.BothRBtn.UseVisualStyleBackColor = true;
            // 
            // SpecialCbx
            // 
            this.SpecialCbx.AutoSize = true;
            this.SpecialCbx.Location = new System.Drawing.Point(157, 69);
            this.SpecialCbx.Name = "SpecialCbx";
            this.SpecialCbx.Size = new System.Drawing.Size(134, 17);
            this.SpecialCbx.TabIndex = 1;
            this.SpecialCbx.Text = "Only Special Character";
            this.SpecialCbx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character Length";
            // 
            // ChLenghtTbx
            // 
            this.ChLenghtTbx.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.ChLenghtTbx.Location = new System.Drawing.Point(109, 126);
            this.ChLenghtTbx.Name = "ChLenghtTbx";
            this.ChLenghtTbx.Size = new System.Drawing.Size(222, 20);
            this.ChLenghtTbx.TabIndex = 3;
            this.ChLenghtTbx.Text = "10";
            // 
            // PwTbx
            // 
            this.PwTbx.ForeColor = System.Drawing.Color.Red;
            this.PwTbx.Location = new System.Drawing.Point(13, 178);
            this.PwTbx.Name = "PwTbx";
            this.PwTbx.ReadOnly = true;
            this.PwTbx.Size = new System.Drawing.Size(367, 20);
            this.PwTbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hard Password";
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(386, 172);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(42, 31);
            this.CopyBtn.TabIndex = 6;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // CreatePwBtn
            // 
            this.CreatePwBtn.Location = new System.Drawing.Point(140, 218);
            this.CreatePwBtn.Name = "CreatePwBtn";
            this.CreatePwBtn.Size = new System.Drawing.Size(154, 28);
            this.CreatePwBtn.TabIndex = 7;
            this.CreatePwBtn.Text = "Create";
            this.CreatePwBtn.UseVisualStyleBackColor = true;
            this.CreatePwBtn.Click += new System.EventHandler(this.CreatePwBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(440, 258);
            this.Controls.Add(this.CreatePwBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PwTbx);
            this.Controls.Add(this.ChLenghtTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpecialCbx);
            this.Controls.Add(this.PasswordTypeGrpBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hard Password Generator";
            this.PasswordTypeGrpBox.ResumeLayout(false);
            this.PasswordTypeGrpBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PasswordTypeGrpBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton LetterRbtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RadioButton NumberRBtn;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.RadioButton BothRBtn;
        private System.Windows.Forms.CheckBox SpecialCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChLenghtTbx;
        private System.Windows.Forms.TextBox PwTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button CreatePwBtn;
    }
}

