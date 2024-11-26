namespace Weterynarz
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
            iin = new TextBox();
            label2 = new Label();
            gatunek = new ComboBox();
            wiek = new TrackBar();
            wiekLiczba = new Label();
            cel = new TextBox();
            godzina = new TextBox();
            check = new Button();
            ((System.ComponentModel.ISupportInitialize)wiek).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(1, -3);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(326, 57);
            label1.TabIndex = 0;
            label1.Text = "Wizyta u weterynarza";
            // 
            // iin
            // 
            iin.Location = new Point(13, 68);
            iin.Name = "iin";
            iin.PlaceholderText = "Imię i nazwisko właściciela...";
            iin.Size = new Size(304, 23);
            iin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 108);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Gatunek";
            // 
            // gatunek
            // 
            gatunek.FormattingEnabled = true;
            gatunek.Items.AddRange(new object[] { "Pies", "Kot", "Świnka morska" });
            gatunek.Location = new Point(12, 135);
            gatunek.Name = "gatunek";
            gatunek.Size = new Size(121, 23);
            gatunek.TabIndex = 3;
            gatunek.SelectedIndexChanged += gatunek_SelectedIndexChanged;
            // 
            // wiek
            // 
            wiek.Location = new Point(89, 251);
            wiek.Name = "wiek";
            wiek.Size = new Size(238, 45);
            wiek.TabIndex = 4;
            wiek.Scroll += wiek_Scroll;
            // 
            // wiekLiczba
            // 
            wiekLiczba.AutoSize = true;
            wiekLiczba.Location = new Point(4, 251);
            wiekLiczba.Name = "wiekLiczba";
            wiekLiczba.Size = new Size(60, 15);
            wiekLiczba.TabIndex = 5;
            wiekLiczba.Text = "Ile ma lat?";
            // 
            // cel
            // 
            cel.Location = new Point(12, 322);
            cel.Name = "cel";
            cel.PlaceholderText = "Cel wizyty";
            cel.Size = new Size(305, 23);
            cel.TabIndex = 6;
            // 
            // godzina
            // 
            godzina.Location = new Point(13, 376);
            godzina.Name = "godzina";
            godzina.PlaceholderText = "Godzina wizyty";
            godzina.Size = new Size(304, 23);
            godzina.TabIndex = 7;
            // 
            // check
            // 
            check.Location = new Point(13, 419);
            check.Name = "check";
            check.Size = new Size(75, 23);
            check.TabIndex = 8;
            check.Text = "OK";
            check.UseVisualStyleBackColor = true;
            check.Click += check_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(329, 535);
            Controls.Add(check);
            Controls.Add(godzina);
            Controls.Add(cel);
            Controls.Add(wiekLiczba);
            Controls.Add(wiek);
            Controls.Add(gatunek);
            Controls.Add(label2);
            Controls.Add(iin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)wiek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox iin;
        private Label label2;
        private ComboBox gatunek;
        private TrackBar wiek;
        private Label wiekLiczba;
        private TextBox cel;
        private TextBox godzina;
        private Button check;
    }
}
