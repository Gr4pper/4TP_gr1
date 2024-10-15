namespace Formularz15._10._24
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
            groupBox1 = new GroupBox();
            job = new ComboBox();
            lastName = new TextBox();
            firstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            passwordGenerate = new Button();
            specialSigns = new CheckBox();
            numbers = new CheckBox();
            letterSize = new CheckBox();
            letterNumber = new TextBox();
            label4 = new Label();
            accept = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(job);
            groupBox1.Controls.Add(lastName);
            groupBox1.Controls.Add(firstName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // job
            // 
            job.FormattingEnabled = true;
            job.Items.AddRange(new object[] { "Dyrektor", "Kierownik", "Magazynier", "" });
            job.Location = new Point(127, 131);
            job.Name = "job";
            job.Size = new Size(121, 23);
            job.TabIndex = 5;
            // 
            // lastName
            // 
            lastName.Location = new Point(127, 89);
            lastName.Name = "lastName";
            lastName.Size = new Size(121, 23);
            lastName.TabIndex = 4;
            // 
            // firstName
            // 
            firstName.Location = new Point(127, 48);
            firstName.Name = "firstName";
            firstName.Size = new Size(121, 23);
            firstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 131);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 92);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordGenerate);
            groupBox2.Controls.Add(specialSigns);
            groupBox2.Controls.Add(numbers);
            groupBox2.Controls.Add(letterSize);
            groupBox2.Controls.Add(letterNumber);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(380, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // passwordGenerate
            // 
            passwordGenerate.BackColor = Color.SteelBlue;
            passwordGenerate.ForeColor = Color.White;
            passwordGenerate.Location = new Point(122, 185);
            passwordGenerate.Margin = new Padding(0);
            passwordGenerate.Name = "passwordGenerate";
            passwordGenerate.Size = new Size(110, 23);
            passwordGenerate.TabIndex = 5;
            passwordGenerate.Text = "Generuj hasło";
            passwordGenerate.UseVisualStyleBackColor = false;
            passwordGenerate.Click += passwordGenerate_Click;
            // 
            // specialSigns
            // 
            specialSigns.AutoSize = true;
            specialSigns.Location = new Point(48, 143);
            specialSigns.Name = "specialSigns";
            specialSigns.Size = new Size(107, 19);
            specialSigns.TabIndex = 4;
            specialSigns.Text = "Znaki specjalne";
            specialSigns.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            numbers.AutoSize = true;
            numbers.Location = new Point(48, 118);
            numbers.Name = "numbers";
            numbers.Size = new Size(54, 19);
            numbers.TabIndex = 3;
            numbers.Text = "Cyfry";
            numbers.UseVisualStyleBackColor = true;
            // 
            // letterSize
            // 
            letterSize.AutoSize = true;
            letterSize.Location = new Point(48, 93);
            letterSize.Name = "letterSize";
            letterSize.Size = new Size(126, 19);
            letterSize.TabIndex = 2;
            letterSize.Text = "Małe i wielkie litery";
            letterSize.UseVisualStyleBackColor = true;
            // 
            // letterNumber
            // 
            letterNumber.Location = new Point(143, 48);
            letterNumber.Name = "letterNumber";
            letterNumber.Size = new Size(128, 23);
            letterNumber.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 51);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // accept
            // 
            accept.BackColor = Color.SteelBlue;
            accept.ForeColor = Color.White;
            accept.Location = new Point(276, 267);
            accept.Name = "accept";
            accept.Size = new Size(148, 23);
            accept.TabIndex = 2;
            accept.Text = "Zatwierdź";
            accept.UseVisualStyleBackColor = false;
            accept.Click += accept_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(747, 303);
            Controls.Add(accept);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox job;
        private TextBox lastName;
        private TextBox firstName;
        private Label label3;
        private TextBox letterNumber;
        private Label label4;
        private Button passwordGenerate;
        private CheckBox specialSigns;
        private CheckBox numbers;
        private CheckBox letterSize;
        private Button accept;
    }
}
