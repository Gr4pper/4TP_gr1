namespace egzamin17_09
{
    partial class Apk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rightSkip = new Button();
            leftSkip = new Button();
            diskImg = new PictureBox();
            author = new Label();
            album = new Label();
            songAmount = new Label();
            year = new Label();
            installsAmount = new Label();
            install = new Button();
            ((System.ComponentModel.ISupportInitialize)diskImg).BeginInit();
            SuspendLayout();
            // 
            // rightSkip
            // 
            rightSkip.Image = Properties.Resources.obraz2;
            rightSkip.Location = new Point(858, 107);
            rightSkip.Name = "rightSkip";
            rightSkip.Size = new Size(98, 70);
            rightSkip.TabIndex = 0;
            rightSkip.UseVisualStyleBackColor = true;
            rightSkip.Click += rightSkip_Click;
            // 
            // leftSkip
            // 
            leftSkip.Image = Properties.Resources.obraz3;
            leftSkip.Location = new Point(12, 107);
            leftSkip.Name = "leftSkip";
            leftSkip.Size = new Size(102, 70);
            leftSkip.TabIndex = 1;
            leftSkip.UseVisualStyleBackColor = true;
            leftSkip.Click += leftSkip_Click;
            // 
            // diskImg
            // 
            diskImg.Image = Properties.Resources.obraz;
            diskImg.Location = new Point(155, 2);
            diskImg.Name = "diskImg";
            diskImg.Size = new Size(201, 196);
            diskImg.TabIndex = 2;
            diskImg.TabStop = false;
            // 
            // author
            // 
            author.Font = new Font("Segoe UI", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            author.ForeColor = Color.White;
            author.Location = new Point(362, 2);
            author.Name = "author";
            author.Size = new Size(603, 81);
            author.TabIndex = 3;
            author.Text = "Author";
            author.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // album
            // 
            album.Font = new Font("Segoe UI", 30F, FontStyle.Italic, GraphicsUnit.Point, 238);
            album.ForeColor = Color.White;
            album.Location = new Point(362, 83);
            album.Name = "album";
            album.Size = new Size(490, 53);
            album.TabIndex = 4;
            album.Text = "\"Album\"";
            album.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // songAmount
            // 
            songAmount.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            songAmount.ForeColor = Color.FromArgb(97, 217, 24);
            songAmount.Location = new Point(362, 136);
            songAmount.Name = "songAmount";
            songAmount.Size = new Size(179, 41);
            songAmount.TabIndex = 5;
            songAmount.Text = "SongAmount";
            songAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // year
            // 
            year.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            year.ForeColor = Color.FromArgb(97, 217, 24);
            year.Location = new Point(547, 136);
            year.Name = "year";
            year.Size = new Size(179, 41);
            year.TabIndex = 6;
            year.Text = "Year";
            year.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // installsAmount
            // 
            installsAmount.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            installsAmount.ForeColor = Color.FromArgb(97, 217, 24);
            installsAmount.Location = new Point(110, 236);
            installsAmount.Name = "installsAmount";
            installsAmount.Size = new Size(183, 41);
            installsAmount.TabIndex = 7;
            installsAmount.Text = "Installs";
            installsAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // install
            // 
            install.BackColor = Color.FromArgb(97, 217, 24);
            install.Cursor = Cursors.Hand;
            install.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            install.ImageAlign = ContentAlignment.TopCenter;
            install.Location = new Point(296, 230);
            install.Margin = new Padding(0);
            install.Name = "install";
            install.Size = new Size(141, 52);
            install.TabIndex = 8;
            install.Text = "Pobierz";
            install.UseVisualStyleBackColor = false;
            install.Click += install_Click;
            // 
            // Apk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(977, 301);
            Controls.Add(install);
            Controls.Add(installsAmount);
            Controls.Add(year);
            Controls.Add(songAmount);
            Controls.Add(album);
            Controls.Add(author);
            Controls.Add(diskImg);
            Controls.Add(leftSkip);
            Controls.Add(rightSkip);
            Name = "Apk";
            Text = "MojeDźwięki. Wykonał: Natan Grynek";
            Load += Apk_Load;
            ((System.ComponentModel.ISupportInitialize)diskImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button rightSkip;
        private Button leftSkip;
        private PictureBox diskImg;
        private Label author;
        private Label album;
        private Label songAmount;
        private Label year;
        private Label installsAmount;
        private Button install;
    }
}
