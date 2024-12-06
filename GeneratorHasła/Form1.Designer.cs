
namespace GeneratorHasła
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImieTB = new System.Windows.Forms.TextBox();
            this.NazwiskoTB = new System.Windows.Forms.TextBox();
            this.DanePracownikaLB = new System.Windows.Forms.Label();
            this.ImieLB = new System.Windows.Forms.Label();
            this.NazwiskoLB = new System.Windows.Forms.Label();
            this.StanowiskoLB = new System.Windows.Forms.Label();
            this.generowanieLB = new System.Windows.Forms.Label();
            this.ileZnakowLB = new System.Windows.Forms.Label();
            this.stanowiskoCombo = new System.Windows.Forms.ComboBox();
            this.liczbaZnakowTB = new System.Windows.Forms.TextBox();
            this.lettersCB = new System.Windows.Forms.CheckBox();
            this.numbersCB = new System.Windows.Forms.CheckBox();
            this.specialCB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImieTB
            // 
            this.ImieTB.Location = new System.Drawing.Point(165, 68);
            this.ImieTB.Name = "ImieTB";
            this.ImieTB.Size = new System.Drawing.Size(126, 20);
            this.ImieTB.TabIndex = 0;
            // 
            // NazwiskoTB
            // 
            this.NazwiskoTB.Location = new System.Drawing.Point(165, 105);
            this.NazwiskoTB.Name = "NazwiskoTB";
            this.NazwiskoTB.Size = new System.Drawing.Size(126, 20);
            this.NazwiskoTB.TabIndex = 1;
            // 
            // DanePracownikaLB
            // 
            this.DanePracownikaLB.AutoSize = true;
            this.DanePracownikaLB.Location = new System.Drawing.Point(49, 31);
            this.DanePracownikaLB.Name = "DanePracownikaLB";
            this.DanePracownikaLB.Size = new System.Drawing.Size(91, 13);
            this.DanePracownikaLB.TabIndex = 3;
            this.DanePracownikaLB.Text = "Dane pracownika";
            this.DanePracownikaLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImieLB
            // 
            this.ImieLB.AutoSize = true;
            this.ImieLB.Location = new System.Drawing.Point(97, 68);
            this.ImieLB.Name = "ImieLB";
            this.ImieLB.Size = new System.Drawing.Size(26, 13);
            this.ImieLB.TabIndex = 4;
            this.ImieLB.Text = "Imię";
            // 
            // NazwiskoLB
            // 
            this.NazwiskoLB.AutoSize = true;
            this.NazwiskoLB.Location = new System.Drawing.Point(96, 105);
            this.NazwiskoLB.Name = "NazwiskoLB";
            this.NazwiskoLB.Size = new System.Drawing.Size(53, 13);
            this.NazwiskoLB.TabIndex = 5;
            this.NazwiskoLB.Text = "Nazwisko";
            // 
            // StanowiskoLB
            // 
            this.StanowiskoLB.AutoSize = true;
            this.StanowiskoLB.Location = new System.Drawing.Point(97, 141);
            this.StanowiskoLB.Name = "StanowiskoLB";
            this.StanowiskoLB.Size = new System.Drawing.Size(62, 13);
            this.StanowiskoLB.TabIndex = 6;
            this.StanowiskoLB.Text = "Stanowisko";
            // 
            // generowanieLB
            // 
            this.generowanieLB.AutoSize = true;
            this.generowanieLB.Location = new System.Drawing.Point(419, 31);
            this.generowanieLB.Name = "generowanieLB";
            this.generowanieLB.Size = new System.Drawing.Size(102, 13);
            this.generowanieLB.TabIndex = 7;
            this.generowanieLB.Text = "Generowanie Hasła";
            // 
            // ileZnakowLB
            // 
            this.ileZnakowLB.AutoSize = true;
            this.ileZnakowLB.Location = new System.Drawing.Point(439, 68);
            this.ileZnakowLB.Name = "ileZnakowLB";
            this.ileZnakowLB.Size = new System.Drawing.Size(64, 13);
            this.ileZnakowLB.TabIndex = 8;
            this.ileZnakowLB.Text = "Ile znaków?";
            // 
            // stanowiskoCombo
            // 
            this.stanowiskoCombo.FormattingEnabled = true;
            this.stanowiskoCombo.Location = new System.Drawing.Point(171, 142);
            this.stanowiskoCombo.Name = "stanowiskoCombo";
            this.stanowiskoCombo.Size = new System.Drawing.Size(119, 21);
            this.stanowiskoCombo.TabIndex = 12;
            // 
            // liczbaZnakowTB
            // 
            this.liczbaZnakowTB.Location = new System.Drawing.Point(519, 61);
            this.liczbaZnakowTB.Name = "liczbaZnakowTB";
            this.liczbaZnakowTB.Size = new System.Drawing.Size(125, 20);
            this.liczbaZnakowTB.TabIndex = 13;
            // 
            // lettersCB
            // 
            this.lettersCB.AutoSize = true;
            this.lettersCB.Location = new System.Drawing.Point(442, 108);
            this.lettersCB.Name = "lettersCB";
            this.lettersCB.Size = new System.Drawing.Size(115, 17);
            this.lettersCB.TabIndex = 14;
            this.lettersCB.Text = "Małe i wielkie litery";
            this.lettersCB.UseVisualStyleBackColor = true;
            // 
            // numbersCB
            // 
            this.numbersCB.AutoSize = true;
            this.numbersCB.Location = new System.Drawing.Point(441, 144);
            this.numbersCB.Name = "numbersCB";
            this.numbersCB.Size = new System.Drawing.Size(49, 17);
            this.numbersCB.TabIndex = 15;
            this.numbersCB.Text = "Cyfry";
            this.numbersCB.UseVisualStyleBackColor = true;
            // 
            // specialCB
            // 
            this.specialCB.AutoSize = true;
            this.specialCB.Location = new System.Drawing.Point(441, 177);
            this.specialCB.Name = "specialCB";
            this.specialCB.Size = new System.Drawing.Size(103, 17);
            this.specialCB.TabIndex = 16;
            this.specialCB.Text = "Znaki Specjalne";
            this.specialCB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generuj Hasło";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(273, 319);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(157, 38);
            this.Accept.TabIndex = 18;
            this.Accept.Text = "zatwierdź";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specialCB);
            this.Controls.Add(this.numbersCB);
            this.Controls.Add(this.lettersCB);
            this.Controls.Add(this.liczbaZnakowTB);
            this.Controls.Add(this.stanowiskoCombo);
            this.Controls.Add(this.ileZnakowLB);
            this.Controls.Add(this.generowanieLB);
            this.Controls.Add(this.StanowiskoLB);
            this.Controls.Add(this.NazwiskoLB);
            this.Controls.Add(this.ImieLB);
            this.Controls.Add(this.DanePracownikaLB);
            this.Controls.Add(this.NazwiskoTB);
            this.Controls.Add(this.ImieTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImieTB;
        private System.Windows.Forms.TextBox NazwiskoTB;
        private System.Windows.Forms.Label DanePracownikaLB;
        private System.Windows.Forms.Label ImieLB;
        private System.Windows.Forms.Label NazwiskoLB;
        private System.Windows.Forms.Label StanowiskoLB;
        private System.Windows.Forms.Label generowanieLB;
        private System.Windows.Forms.Label ileZnakowLB;
        private System.Windows.Forms.ComboBox stanowiskoCombo;
        private System.Windows.Forms.TextBox liczbaZnakowTB;
        private System.Windows.Forms.CheckBox lettersCB;
        private System.Windows.Forms.CheckBox numbersCB;
        private System.Windows.Forms.CheckBox specialCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Accept;
    }
}

