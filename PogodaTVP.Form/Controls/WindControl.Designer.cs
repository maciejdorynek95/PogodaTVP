namespace PogodaTVP.UI.Controls
{
    partial class WindControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_WeatherDirectory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kierunek wiatru";
            // 
            // comboBox_WeatherDirectory
            // 
            this.comboBox_WeatherDirectory.FormattingEnabled = true;
            this.comboBox_WeatherDirectory.Location = new System.Drawing.Point(3, 65);
            this.comboBox_WeatherDirectory.Name = "comboBox_WeatherDirectory";
            this.comboBox_WeatherDirectory.Size = new System.Drawing.Size(179, 23);
            this.comboBox_WeatherDirectory.TabIndex = 1;
            // 
            // WindControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.comboBox_WeatherDirectory);
            this.Controls.Add(this.label1);
            this.Name = "WindControl";
            this.Size = new System.Drawing.Size(185, 240);
            this.Load += new System.EventHandler(this.WindControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_WeatherDirectory;
    }
}
