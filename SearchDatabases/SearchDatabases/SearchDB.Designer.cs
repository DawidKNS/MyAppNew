namespace SearchDatabases
{
    partial class SearchDB
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
            this.dataGridView_SearchDB = new System.Windows.Forms.DataGridView();
            this.GetFromDB = new System.Windows.Forms.Button();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox_CV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Stanowisko = new System.Windows.Forms.Label();
            this.label_lokalizacja = new System.Windows.Forms.Label();
            this.label_notatki = new System.Windows.Forms.Label();
            this.label_CV = new System.Windows.Forms.Label();
            this.button_Added_New_Data = new System.Windows.Forms.Button();
            this.button_UpdataData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SearchDB
            // 
            this.dataGridView_SearchDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchDB.Location = new System.Drawing.Point(12, 60);
            this.dataGridView_SearchDB.Name = "dataGridView_SearchDB";
            this.dataGridView_SearchDB.Size = new System.Drawing.Size(1112, 818);
            this.dataGridView_SearchDB.TabIndex = 0;
            // 
            // GetFromDB
            // 
            this.GetFromDB.Location = new System.Drawing.Point(12, 12);
            this.GetFromDB.Name = "GetFromDB";
            this.GetFromDB.Size = new System.Drawing.Size(144, 23);
            this.GetFromDB.TabIndex = 1;
            this.GetFromDB.Text = "Get From Database";
            this.GetFromDB.UseVisualStyleBackColor = true;
            this.GetFromDB.Click += new System.EventHandler(this.GetFromDB_Click);
            // 
            // textBox_imie
            // 
            this.textBox_imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_imie.Location = new System.Drawing.Point(1266, 60);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(206, 26);
            this.textBox_imie.TabIndex = 3;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwisko.Location = new System.Drawing.Point(1266, 92);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(206, 26);
            this.textBox_nazwisko.TabIndex = 4;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Status.Location = new System.Drawing.Point(1266, 124);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(206, 26);
            this.textBox_Status.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(1266, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 26);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(1266, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 26);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(1266, 220);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 26);
            this.textBox6.TabIndex = 8;
            // 
            // textBox_CV
            // 
            this.textBox_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_CV.Location = new System.Drawing.Point(1266, 252);
            this.textBox_CV.Name = "textBox_CV";
            this.textBox_CV.Size = new System.Drawing.Size(206, 26);
            this.textBox_CV.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1154, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1154, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Status.Location = new System.Drawing.Point(1154, 124);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(62, 20);
            this.label_Status.TabIndex = 12;
            this.label_Status.Text = "Status";
            // 
            // label_Stanowisko
            // 
            this.label_Stanowisko.AutoSize = true;
            this.label_Stanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Stanowisko.Location = new System.Drawing.Point(1154, 156);
            this.label_Stanowisko.Name = "label_Stanowisko";
            this.label_Stanowisko.Size = new System.Drawing.Size(101, 20);
            this.label_Stanowisko.TabIndex = 13;
            this.label_Stanowisko.Text = "Stanowisko";
            // 
            // label_lokalizacja
            // 
            this.label_lokalizacja.AutoSize = true;
            this.label_lokalizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_lokalizacja.Location = new System.Drawing.Point(1154, 188);
            this.label_lokalizacja.Name = "label_lokalizacja";
            this.label_lokalizacja.Size = new System.Drawing.Size(98, 20);
            this.label_lokalizacja.TabIndex = 14;
            this.label_lokalizacja.Text = "Lokalizacja";
            // 
            // label_notatki
            // 
            this.label_notatki.AutoSize = true;
            this.label_notatki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_notatki.Location = new System.Drawing.Point(1154, 220);
            this.label_notatki.Name = "label_notatki";
            this.label_notatki.Size = new System.Drawing.Size(66, 20);
            this.label_notatki.TabIndex = 15;
            this.label_notatki.Text = "Notatki";
            // 
            // label_CV
            // 
            this.label_CV.AutoSize = true;
            this.label_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CV.Location = new System.Drawing.Point(1154, 252);
            this.label_CV.Name = "label_CV";
            this.label_CV.Size = new System.Drawing.Size(33, 20);
            this.label_CV.TabIndex = 16;
            this.label_CV.Text = "CV";
            // 
            // button_Added_New_Data
            // 
            this.button_Added_New_Data.Location = new System.Drawing.Point(1266, 315);
            this.button_Added_New_Data.Name = "button_Added_New_Data";
            this.button_Added_New_Data.Size = new System.Drawing.Size(206, 23);
            this.button_Added_New_Data.TabIndex = 17;
            this.button_Added_New_Data.Text = "Added New Data";
            this.button_Added_New_Data.UseVisualStyleBackColor = true;
            // 
            // button_UpdataData
            // 
            this.button_UpdataData.Location = new System.Drawing.Point(1266, 344);
            this.button_UpdataData.Name = "button_UpdataData";
            this.button_UpdataData.Size = new System.Drawing.Size(206, 23);
            this.button_UpdataData.TabIndex = 18;
            this.button_UpdataData.Text = "Update Data";
            this.button_UpdataData.UseVisualStyleBackColor = true;
            // 
            // SearchDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 890);
            this.Controls.Add(this.button_UpdataData);
            this.Controls.Add(this.button_Added_New_Data);
            this.Controls.Add(this.label_CV);
            this.Controls.Add(this.label_notatki);
            this.Controls.Add(this.label_lokalizacja);
            this.Controls.Add(this.label_Stanowisko);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CV);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.GetFromDB);
            this.Controls.Add(this.dataGridView_SearchDB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchDB";
            this.Text = "Data Bases People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SearchDB;
        private System.Windows.Forms.Button GetFromDB;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_CV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Stanowisko;
        private System.Windows.Forms.Label label_lokalizacja;
        private System.Windows.Forms.Label label_notatki;
        private System.Windows.Forms.Label label_CV;
        private System.Windows.Forms.Button button_Added_New_Data;
        private System.Windows.Forms.Button button_UpdataData;
    }
}

