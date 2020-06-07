namespace Хакатон_4_Кейс
{
    partial class profileForm
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
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.userEdit = new FontAwesome.Sharp.IconButton();
            this.loadPic = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Newpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Oldpassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.Image = global::Хакатон_4_Кейс.Properties.Resources._213;
            this.profilePic.Location = new System.Drawing.Point(41, 32);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(145, 151);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // userEdit
            // 
            this.userEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.userEdit.FlatAppearance.BorderSize = 0;
            this.userEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEdit.ForeColor = System.Drawing.Color.White;
            this.userEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.userEdit.IconColor = System.Drawing.Color.White;
            this.userEdit.IconSize = 24;
            this.userEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userEdit.Location = new System.Drawing.Point(14, 138);
            this.userEdit.Name = "userEdit";
            this.userEdit.Rotation = 0D;
            this.userEdit.Size = new System.Drawing.Size(145, 32);
            this.userEdit.TabIndex = 1;
            this.userEdit.Text = "Сохранить";
            this.userEdit.UseVisualStyleBackColor = false;
            this.userEdit.Click += new System.EventHandler(this.userEdit_Click);
            // 
            // loadPic
            // 
            this.loadPic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadPic.ForeColor = System.Drawing.Color.White;
            this.loadPic.Location = new System.Drawing.Point(41, 189);
            this.loadPic.Name = "loadPic";
            this.loadPic.Size = new System.Drawing.Size(145, 27);
            this.loadPic.TabIndex = 4;
            this.loadPic.Text = "Загрузить изображение";
            this.loadPic.UseVisualStyleBackColor = false;
            this.loadPic.Click += new System.EventHandler(this.loadPic_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Имя Фамилия";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(29, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 214);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(240, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 214);
            this.panel2.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(20, 50);
            this.richTextBox1.MaxLength = 120;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 117);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Изменить описание";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Рейтинг: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Newpassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Oldpassword);
            this.panel3.Controls.Add(this.userEdit);
            this.panel3.Location = new System.Drawing.Point(29, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 184);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Новый пароль";
            // 
            // Newpassword
            // 
            this.Newpassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Newpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Newpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Newpassword.ForeColor = System.Drawing.Color.White;
            this.Newpassword.Location = new System.Drawing.Point(14, 92);
            this.Newpassword.MaxLength = 20;
            this.Newpassword.Name = "Newpassword";
            this.Newpassword.PasswordChar = '*';
            this.Newpassword.Size = new System.Drawing.Size(145, 28);
            this.Newpassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Старый пароль";
            // 
            // Oldpassword
            // 
            this.Oldpassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Oldpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Oldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oldpassword.ForeColor = System.Drawing.Color.White;
            this.Oldpassword.Location = new System.Drawing.Point(14, 31);
            this.Oldpassword.MaxLength = 20;
            this.Oldpassword.Name = "Oldpassword";
            this.Oldpassword.PasswordChar = '*';
            this.Oldpassword.Size = new System.Drawing.Size(145, 28);
            this.Oldpassword.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(240, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 184);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Последние записи";
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 464);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loadPic);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileForm";
            this.Text = "profileForm";
            this.Load += new System.EventHandler(this.profileForm_Load_1);
            this.Shown += new System.EventHandler(this.profileForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private FontAwesome.Sharp.IconButton userEdit;
        private System.Windows.Forms.Button loadPic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Newpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Oldpassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
    }
}