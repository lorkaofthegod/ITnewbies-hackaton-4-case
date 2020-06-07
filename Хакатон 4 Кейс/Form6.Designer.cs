namespace Хакатон_4_Кейс
{
    partial class Form6
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
            this.userEdit = new FontAwesome.Sharp.IconButton();
            this.loadPic = new System.Windows.Forms.Button();
            this.textpost = new System.Windows.Forms.RichTextBox();
            this.theme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.userEdit.Location = new System.Drawing.Point(543, 424);
            this.userEdit.Name = "userEdit";
            this.userEdit.Rotation = 0D;
            this.userEdit.Size = new System.Drawing.Size(150, 32);
            this.userEdit.TabIndex = 12;
            this.userEdit.Text = "Опубликовать";
            this.userEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.loadPic.Location = new System.Drawing.Point(381, 425);
            this.loadPic.Name = "loadPic";
            this.loadPic.Size = new System.Drawing.Size(145, 32);
            this.loadPic.TabIndex = 15;
            this.loadPic.Text = "Загрузить изображения";
            this.loadPic.UseVisualStyleBackColor = false;
            // 
            // textpost
            // 
            this.textpost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textpost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpost.ForeColor = System.Drawing.Color.Transparent;
            this.textpost.Location = new System.Drawing.Point(66, 80);
            this.textpost.MaxLength = 700;
            this.textpost.Name = "textpost";
            this.textpost.Size = new System.Drawing.Size(627, 338);
            this.textpost.TabIndex = 14;
            this.textpost.Text = "Введите сообщение чтоли";
            this.textpost.Click += new System.EventHandler(this.textpost_Click);
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.theme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme.ForeColor = System.Drawing.Color.White;
            this.theme.Location = new System.Drawing.Point(66, 46);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(627, 28);
            this.theme.TabIndex = 13;
            this.theme.Text = "Тема";
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 464);
            this.Controls.Add(this.userEdit);
            this.Controls.Add(this.loadPic);
            this.Controls.Add(this.textpost);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton userEdit;
        private System.Windows.Forms.Button loadPic;
        private System.Windows.Forms.RichTextBox textpost;
        private System.Windows.Forms.TextBox theme;
    }
}