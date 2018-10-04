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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SearchDB
            // 
            this.dataGridView_SearchDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchDB.Location = new System.Drawing.Point(12, 120);
            this.dataGridView_SearchDB.Name = "dataGridView_SearchDB";
            this.dataGridView_SearchDB.Size = new System.Drawing.Size(1112, 758);
            this.dataGridView_SearchDB.TabIndex = 0;
            // 
            // GetFromDB
            // 
            this.GetFromDB.Location = new System.Drawing.Point(12, 72);
            this.GetFromDB.Name = "GetFromDB";
            this.GetFromDB.Size = new System.Drawing.Size(144, 23);
            this.GetFromDB.TabIndex = 1;
            this.GetFromDB.Text = "Get From Database";
            this.GetFromDB.UseVisualStyleBackColor = true;
            this.GetFromDB.Click += new System.EventHandler(this.GetFromDB_Click);
            // 
            // SearchDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 890);
            this.Controls.Add(this.GetFromDB);
            this.Controls.Add(this.dataGridView_SearchDB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchDB";
            this.Text = "Data Bases People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SearchDB;
        private System.Windows.Forms.Button GetFromDB;
    }
}

