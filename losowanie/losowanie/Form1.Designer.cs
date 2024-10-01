namespace losowanie
{
    partial class Form1
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
            label1 = new Label();
            rzut = new Button();
            img1 = new PictureBox();
            wynik = new Label();
            wynikGry = new Label();
            reset = new Button();
            img2 = new PictureBox();
            img3 = new PictureBox();
            img4 = new PictureBox();
            img5 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)img1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(-2, 22);
            label1.Name = "label1";
            label1.Size = new Size(521, 35);
            label1.TabIndex = 0;
            label1.Text = "Gra w kości";
            // 
            // rzut
            // 
            rzut.BackColor = Color.Chocolate;
            rzut.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rzut.ForeColor = Color.White;
            rzut.Location = new Point(186, 77);
            rzut.Margin = new Padding(0);
            rzut.Name = "rzut";
            rzut.Size = new Size(155, 47);
            rzut.TabIndex = 1;
            rzut.Text = "Rzuć kośćmi";
            rzut.UseVisualStyleBackColor = false;
            rzut.Click += rzut_Click;
            // 
            // img1
            // 
            img1.Image = Properties.Resources.kosc1;
            img1.Location = new Point(0, 0);
            img1.Name = "img1";
            img1.Size = new Size(99, 100);
            img1.SizeMode = PictureBoxSizeMode.CenterImage;
            img1.TabIndex = 0;
            img1.TabStop = false;
            // 
            // wynik
            // 
            wynik.AutoSize = true;
            wynik.Location = new Point(192, 322);
            wynik.Name = "wynik";
            wynik.Size = new Size(149, 15);
            wynik.TabIndex = 3;
            wynik.Text = "Wynik tego losowania to: 0";
            // 
            // wynikGry
            // 
            wynikGry.AutoSize = true;
            wynikGry.Location = new Point(233, 361);
            wynikGry.Name = "wynikGry";
            wynikGry.Size = new Size(72, 15);
            wynikGry.TabIndex = 4;
            wynikGry.Text = "Wynik gry: 0";
            // 
            // reset
            // 
            reset.BackColor = Color.Chocolate;
            reset.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            reset.ForeColor = Color.White;
            reset.Location = new Point(186, 395);
            reset.Margin = new Padding(0);
            reset.Name = "reset";
            reset.Size = new Size(155, 47);
            reset.TabIndex = 5;
            reset.Text = "Resetuj gre";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // img2
            // 
            img2.Image = Properties.Resources.kosc1;
            img2.Location = new Point(105, 0);
            img2.Name = "img2";
            img2.Size = new Size(98, 100);
            img2.SizeMode = PictureBoxSizeMode.CenterImage;
            img2.TabIndex = 1;
            img2.TabStop = false;
            // 
            // img3
            // 
            img3.Image = Properties.Resources.kosc1;
            img3.Location = new Point(209, 0);
            img3.Name = "img3";
            img3.Size = new Size(98, 100);
            img3.SizeMode = PictureBoxSizeMode.CenterImage;
            img3.TabIndex = 2;
            img3.TabStop = false;
            // 
            // img4
            // 
            img4.Image = Properties.Resources.kosc1;
            img4.Location = new Point(313, 0);
            img4.Name = "img4";
            img4.Size = new Size(98, 100);
            img4.SizeMode = PictureBoxSizeMode.CenterImage;
            img4.TabIndex = 3;
            img4.TabStop = false;
            // 
            // img5
            // 
            img5.Image = Properties.Resources.kosc1;
            img5.Location = new Point(417, 0);
            img5.Name = "img5";
            img5.Size = new Size(98, 100);
            img5.SizeMode = PictureBoxSizeMode.CenterImage;
            img5.TabIndex = 4;
            img5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(img5);
            panel1.Controls.Add(img4);
            panel1.Controls.Add(img3);
            panel1.Controls.Add(img2);
            panel1.Controls.Add(img1);
            panel1.Location = new Point(-2, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 100);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(517, 516);
            Controls.Add(reset);
            Controls.Add(wynikGry);
            Controls.Add(wynik);
            Controls.Add(panel1);
            Controls.Add(rzut);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)img1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img2).EndInit();
            ((System.ComponentModel.ISupportInitialize)img3).EndInit();
            ((System.ComponentModel.ISupportInitialize)img4).EndInit();
            ((System.ComponentModel.ISupportInitialize)img5).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button rzut;
        private PictureBox img1;
        private Label wynik;
        private Label wynikGry;
        private Button reset;
        private PictureBox img2;
        private PictureBox img3;
        private PictureBox img4;
        private PictureBox img5;
        private Panel panel1;
    }
}
