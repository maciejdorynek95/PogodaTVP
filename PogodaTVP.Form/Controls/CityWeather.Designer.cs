namespace PogodaTVP.UI.Controls
{
    partial class CityWeather
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
            this.label1_City = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_temp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_Pressure = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_Data = new System.Windows.Forms.DateTimePicker();
            this.comboBox1_SytuacjaPogodowa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_City
            // 
            this.label1_City.AutoSize = true;
            this.label1_City.Location = new System.Drawing.Point(14, 13);
            this.label1_City.Name = "label1_City";
            this.label1_City.Size = new System.Drawing.Size(76, 15);
            this.label1_City.TabIndex = 0;
            this.label1_City.Text = "N/A - Miasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2_temp
            // 
            this.textBox2_temp.Location = new System.Drawing.Point(122, 84);
            this.textBox2_temp.Name = "textBox2_temp";
            this.textBox2_temp.Size = new System.Drawing.Size(49, 23);
            this.textBox2_temp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciśnienie Hpa";
            // 
            // textBox3_Pressure
            // 
            this.textBox3_Pressure.Location = new System.Drawing.Point(122, 113);
            this.textBox3_Pressure.Name = "textBox3_Pressure";
            this.textBox3_Pressure.Size = new System.Drawing.Size(49, 23);
            this.textBox3_Pressure.TabIndex = 5;
            // 
            // dateTimePicker1_Data
            // 
            this.dateTimePicker1_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_Data.Location = new System.Drawing.Point(15, 45);
            this.dateTimePicker1_Data.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1_Data.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1_Data.Name = "dateTimePicker1_Data";
            this.dateTimePicker1_Data.Size = new System.Drawing.Size(154, 23);
            this.dateTimePicker1_Data.TabIndex = 7;
            // 
            // comboBox1_SytuacjaPogodowa
            // 
            this.comboBox1_SytuacjaPogodowa.FormattingEnabled = true;
            this.comboBox1_SytuacjaPogodowa.Location = new System.Drawing.Point(17, 186);
            this.comboBox1_SytuacjaPogodowa.Name = "comboBox1_SytuacjaPogodowa";
            this.comboBox1_SytuacjaPogodowa.Size = new System.Drawing.Size(144, 23);
            this.comboBox1_SytuacjaPogodowa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sytuacja pogodowa";
            // 
            // CityWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1_SytuacjaPogodowa);
            this.Controls.Add(this.dateTimePicker1_Data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3_Pressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_temp);
            this.Controls.Add(this.label1_City);
            this.Name = "CityWeather";
            this.Size = new System.Drawing.Size(185, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1_City;
        public System.Windows.Forms.DateTimePicker dateTimePicker1_Data;
        public System.Windows.Forms.TextBox textBox2_temp;
        public System.Windows.Forms.TextBox textBox3_Pressure;
        public System.Windows.Forms.ComboBox comboBox1_SytuacjaPogodowa;
    }
}
