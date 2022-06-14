namespace fakturacefiller
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LvData = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Číslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odběratel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Název = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Počet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cenaza1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Celkcena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenasDPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvData
            // 
            this.LvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Datum,
            this.Číslo,
            this.Odběratel,
            this.Název,
            this.Počet,
            this.Cenaza1,
            this.Celkcena,
            this.DPH,
            this.CenasDPH});
            this.LvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvData.GridLines = true;
            this.LvData.HideSelection = false;
            this.LvData.Location = new System.Drawing.Point(0, 0);
            this.LvData.Name = "LvData";
            this.LvData.Size = new System.Drawing.Size(800, 450);
            this.LvData.TabIndex = 0;
            this.LvData.UseCompatibleStateImageBehavior = false;
            this.LvData.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            // 
            // Číslo
            // 
            this.Číslo.Text = "Číslo";
            // 
            // Odběratel
            // 
            this.Odběratel.Text = "Odběratel";
            // 
            // Název
            // 
            this.Název.Text = "Název";
            // 
            // Počet
            // 
            this.Počet.Text = "Počet";
            // 
            // Cenaza1
            // 
            this.Cenaza1.Text = "Cenaza1";
            // 
            // Celkcena
            // 
            this.Celkcena.Text = "Celkcena";
            // 
            // DPH
            // 
            this.DPH.Text = "DPH";
            // 
            // CenasDPH
            // 
            this.CenasDPH.Text = "CenasDPH";
            this.CenasDPH.Width = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LvData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvData;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Číslo;
        private System.Windows.Forms.ColumnHeader Odběratel;
        private System.Windows.Forms.ColumnHeader Název;
        private System.Windows.Forms.ColumnHeader Počet;
        private System.Windows.Forms.ColumnHeader Cenaza1;
        private System.Windows.Forms.ColumnHeader Celkcena;
        private System.Windows.Forms.ColumnHeader DPH;
        private System.Windows.Forms.ColumnHeader CenasDPH;
    }
}