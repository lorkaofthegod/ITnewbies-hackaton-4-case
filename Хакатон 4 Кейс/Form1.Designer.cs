namespace Хакатон_4_Кейс
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.postsBtn = new FontAwesome.Sharp.IconButton();
            this.profileBtn = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.RichTextBox();
            this.emblem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emblem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.postsBtn);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 503);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 28;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(12, 413);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(100, 48);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.Text = "Выйти";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 28;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(12, 317);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(109, 48);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "Лидеры мнений";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 209);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(100, 48);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Новая запись";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // postsBtn
            // 
            this.postsBtn.FlatAppearance.BorderSize = 0;
            this.postsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.postsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postsBtn.ForeColor = System.Drawing.Color.White;
            this.postsBtn.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.postsBtn.IconColor = System.Drawing.Color.White;
            this.postsBtn.IconSize = 28;
            this.postsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postsBtn.Location = new System.Drawing.Point(12, 116);
            this.postsBtn.Name = "postsBtn";
            this.postsBtn.Rotation = 0D;
            this.postsBtn.Size = new System.Drawing.Size(109, 34);
            this.postsBtn.TabIndex = 6;
            this.postsBtn.Text = "Записи";
            this.postsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.postsBtn.UseVisualStyleBackColor = true;
            this.postsBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.profileBtn.IconColor = System.Drawing.Color.White;
            this.profileBtn.IconSize = 28;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(12, 33);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Rotation = 0D;
            this.profileBtn.Size = new System.Drawing.Size(128, 30);
            this.profileBtn.TabIndex = 5;
            this.profileBtn.Text = "Профиль";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Orange;
            this.panelChildForm.Controls.Add(this.welcome);
            this.panelChildForm.Controls.Add(this.emblem);
            this.panelChildForm.Controls.Add(this.button1);
            this.panelChildForm.Location = new System.Drawing.Point(157, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(780, 503);
            this.panelChildForm.TabIndex = 5;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Orange;
            this.welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.welcome.Location = new System.Drawing.Point(67, 222);
            this.welcome.Name = "welcome";
            this.welcome.ReadOnly = true;
            this.welcome.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.welcome.Size = new System.Drawing.Size(513, 185);
            this.welcome.TabIndex = 5;
            this.welcome.Text = resources.GetString("welcome.Text");
            // 
            // emblem
            // 
            this.emblem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emblem.Image = global::Хакатон_4_Кейс.Properties.Resources._213;
            this.emblem.InitialImage = global::Хакатон_4_Кейс.Properties.Resources._1;
            this.emblem.Location = new System.Drawing.Point(116, 33);
            this.emblem.Name = "emblem";
            this.emblem.Size = new System.Drawing.Size(369, 155);
            this.emblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emblem.TabIndex = 4;
            this.emblem.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(203, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emblem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton postsBtn;
        private FontAwesome.Sharp.IconButton profileBtn;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.RichTextBox welcome;
        private System.Windows.Forms.PictureBox emblem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

