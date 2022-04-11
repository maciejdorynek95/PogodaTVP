namespace PogodaTVP.UI
{
    partial class ClientPanel
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1_footer = new System.Windows.Forms.Panel();
            this.button_Clean = new System.Windows.Forms.Button();
            this.button_GenerateAdobe = new System.Windows.Forms.Button();
            this.checkedListBox_Days = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_WeatherParts = new System.Windows.Forms.CheckedListBox();
            this.button1_PobierzPogode = new System.Windows.Forms.Button();
            this.panel1_leftSidebar = new System.Windows.Forms.Panel();
            this.panel_middle = new System.Windows.Forms.Panel();
            this.tabControl_Kolejne3Dni = new System.Windows.Forms.TabControl();
            this.tabPage1_OpolszczyznaNoc = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_OpolszczyznaNoc = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage5_PolskaDzien = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_PolskaDzien = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage4_Kolejne3Dni = new System.Windows.Forms.TabPage();
            this.button1_GenerateNext3Days = new System.Windows.Forms.Button();
            this.panel1_footer.SuspendLayout();
            this.panel_middle.SuspendLayout();
            this.tabControl_Kolejne3Dni.SuspendLayout();
            this.tabPage1_OpolszczyznaNoc.SuspendLayout();
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.SuspendLayout();
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.SuspendLayout();
            this.tabPage5_PolskaDzien.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1_footer
            // 
            this.panel1_footer.AutoSize = true;
            this.panel1_footer.Controls.Add(this.button1_GenerateNext3Days);
            this.panel1_footer.Controls.Add(this.button_Clean);
            this.panel1_footer.Controls.Add(this.button_GenerateAdobe);
            this.panel1_footer.Controls.Add(this.checkedListBox_Days);
            this.panel1_footer.Controls.Add(this.checkedListBox_WeatherParts);
            this.panel1_footer.Controls.Add(this.button1_PobierzPogode);
            this.panel1_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1_footer.Location = new System.Drawing.Point(0, 380);
            this.panel1_footer.MinimumSize = new System.Drawing.Size(0, 100);
            this.panel1_footer.Name = "panel1_footer";
            this.panel1_footer.Size = new System.Drawing.Size(1172, 103);
            this.panel1_footer.TabIndex = 0;
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(506, 39);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(272, 23);
            this.button_Clean.TabIndex = 5;
            this.button_Clean.Text = "Wyczyść";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // button_GenerateAdobe
            // 
            this.button_GenerateAdobe.Location = new System.Drawing.Point(259, 68);
            this.button_GenerateAdobe.Name = "button_GenerateAdobe";
            this.button_GenerateAdobe.Size = new System.Drawing.Size(241, 23);
            this.button_GenerateAdobe.TabIndex = 4;
            this.button_GenerateAdobe.Text = "Generuj Adobe Premiere Wybrany Dzien";
            this.button_GenerateAdobe.UseVisualStyleBackColor = true;
            this.button_GenerateAdobe.Click += new System.EventHandler(this.button_GenerateAdobe_Click);
            // 
            // checkedListBox_Days
            // 
            this.checkedListBox_Days.CheckOnClick = true;
            this.checkedListBox_Days.FormattingEnabled = true;
            this.checkedListBox_Days.Items.AddRange(new object[] {
            "Dzis",
            "Jutro",
            "Po jutrze",
            "Po Pojutrze"});
            this.checkedListBox_Days.Location = new System.Drawing.Point(7, 6);
            this.checkedListBox_Days.Name = "checkedListBox_Days";
            this.checkedListBox_Days.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Days.TabIndex = 3;
            this.checkedListBox_Days.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Days_ItemCheck);
            // 
            // checkedListBox_WeatherParts
            // 
            this.checkedListBox_WeatherParts.CheckOnClick = true;
            this.checkedListBox_WeatherParts.FormattingEnabled = true;
            this.checkedListBox_WeatherParts.Items.AddRange(new object[] {
            "Przed Poludniem",
            "Po Poludniu",
            "Noc"});
            this.checkedListBox_WeatherParts.Location = new System.Drawing.Point(133, 6);
            this.checkedListBox_WeatherParts.Name = "checkedListBox_WeatherParts";
            this.checkedListBox_WeatherParts.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_WeatherParts.TabIndex = 2;
            // 
            // button1_PobierzPogode
            // 
            this.button1_PobierzPogode.Location = new System.Drawing.Point(259, 39);
            this.button1_PobierzPogode.Name = "button1_PobierzPogode";
            this.button1_PobierzPogode.Size = new System.Drawing.Size(241, 23);
            this.button1_PobierzPogode.TabIndex = 0;
            this.button1_PobierzPogode.Text = "Pobierz pogode";
            this.button1_PobierzPogode.UseVisualStyleBackColor = true;
            this.button1_PobierzPogode.Click += new System.EventHandler(this.button1_Click_PobierzPogode);
            // 
            // panel1_leftSidebar
            // 
            this.panel1_leftSidebar.AutoSize = true;
            this.panel1_leftSidebar.Location = new System.Drawing.Point(12, 123);
            this.panel1_leftSidebar.MinimumSize = new System.Drawing.Size(100, 0);
            this.panel1_leftSidebar.Name = "panel1_leftSidebar";
            this.panel1_leftSidebar.Size = new System.Drawing.Size(100, 221);
            this.panel1_leftSidebar.TabIndex = 1;
            // 
            // panel_middle
            // 
            this.panel_middle.AutoSize = true;
            this.panel_middle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_middle.Controls.Add(this.tabControl_Kolejne3Dni);
            this.panel_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_middle.Location = new System.Drawing.Point(0, 0);
            this.panel_middle.MinimumSize = new System.Drawing.Size(0, 100);
            this.panel_middle.Name = "panel_middle";
            this.panel_middle.Size = new System.Drawing.Size(1172, 380);
            this.panel_middle.TabIndex = 1;
            // 
            // tabControl_Kolejne3Dni
            // 
            this.tabControl_Kolejne3Dni.Controls.Add(this.tabPage1_OpolszczyznaNoc);
            this.tabControl_Kolejne3Dni.Controls.Add(this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem);
            this.tabControl_Kolejne3Dni.Controls.Add(this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu);
            this.tabControl_Kolejne3Dni.Controls.Add(this.tabPage4_Kolejne3Dni);
            this.tabControl_Kolejne3Dni.Controls.Add(this.tabPage5_PolskaDzien);
            this.tabControl_Kolejne3Dni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Kolejne3Dni.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Kolejne3Dni.MinimumSize = new System.Drawing.Size(100, 100);
            this.tabControl_Kolejne3Dni.Name = "tabControl_Kolejne3Dni";
            this.tabControl_Kolejne3Dni.SelectedIndex = 0;
            this.tabControl_Kolejne3Dni.Size = new System.Drawing.Size(1172, 380);
            this.tabControl_Kolejne3Dni.TabIndex = 0;
            // 
            // tabPage1_OpolszczyznaNoc
            // 
            this.tabPage1_OpolszczyznaNoc.Controls.Add(this.flowLayoutPanel_OpolszczyznaNoc);
            this.tabPage1_OpolszczyznaNoc.Location = new System.Drawing.Point(4, 24);
            this.tabPage1_OpolszczyznaNoc.Name = "tabPage1_OpolszczyznaNoc";
            this.tabPage1_OpolszczyznaNoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_OpolszczyznaNoc.Size = new System.Drawing.Size(1164, 352);
            this.tabPage1_OpolszczyznaNoc.TabIndex = 1;
            this.tabPage1_OpolszczyznaNoc.Text = "Noc na Opolszczyznie";
            this.tabPage1_OpolszczyznaNoc.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_OpolszczyznaNoc
            // 
            this.flowLayoutPanel_OpolszczyznaNoc.AutoScroll = true;
            this.flowLayoutPanel_OpolszczyznaNoc.AutoSize = true;
            this.flowLayoutPanel_OpolszczyznaNoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_OpolszczyznaNoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_OpolszczyznaNoc.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_OpolszczyznaNoc.MinimumSize = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel_OpolszczyznaNoc.Name = "flowLayoutPanel_OpolszczyznaNoc";
            this.flowLayoutPanel_OpolszczyznaNoc.Size = new System.Drawing.Size(1158, 346);
            this.flowLayoutPanel_OpolszczyznaNoc.TabIndex = 1;
            // 
            // tabPage2_Opolszczyzna_Dzien_Przed_Poludniem
            // 
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.Controls.Add(this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem);
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.Location = new System.Drawing.Point(4, 24);
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.Name = "tabPage2_Opolszczyzna_Dzien_Przed_Poludniem";
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.Size = new System.Drawing.Size(1164, 352);
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.TabIndex = 0;
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.Text = "Dzien na Opolszczyznie - przed poludniem";
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem
            // 
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.AutoScroll = true;
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.AutoSize = true;
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.MinimumSize = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Name = "flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem";
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Size = new System.Drawing.Size(1158, 346);
            this.flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.TabIndex = 0;
            // 
            // tabPage3_Opolszczyzna_Dzien_Po_Poludniu
            // 
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.Controls.Add(this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu);
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.Location = new System.Drawing.Point(4, 24);
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.Name = "tabPage3_Opolszczyzna_Dzien_Po_Poludniu";
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.Size = new System.Drawing.Size(1164, 352);
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.TabIndex = 2;
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.Text = "Dzien na Opolszczyznie - po poludniu";
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu
            // 
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.AutoScroll = true;
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.AutoSize = true;
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.MinimumSize = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Name = "flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu";
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Size = new System.Drawing.Size(1164, 352);
            this.flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.TabIndex = 2;
            // 
            // tabPage5_PolskaDzien
            // 
            this.tabPage5_PolskaDzien.Controls.Add(this.flowLayoutPanel_PolskaDzien);
            this.tabPage5_PolskaDzien.Location = new System.Drawing.Point(4, 24);
            this.tabPage5_PolskaDzien.Name = "tabPage5_PolskaDzien";
            this.tabPage5_PolskaDzien.Size = new System.Drawing.Size(1164, 352);
            this.tabPage5_PolskaDzien.TabIndex = 4;
            this.tabPage5_PolskaDzien.Text = "Polska Dzien";
            this.tabPage5_PolskaDzien.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_PolskaDzien
            // 
            this.flowLayoutPanel_PolskaDzien.AutoScroll = true;
            this.flowLayoutPanel_PolskaDzien.AutoSize = true;
            this.flowLayoutPanel_PolskaDzien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_PolskaDzien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_PolskaDzien.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_PolskaDzien.Name = "flowLayoutPanel_PolskaDzien";
            this.flowLayoutPanel_PolskaDzien.Size = new System.Drawing.Size(1164, 352);
            this.flowLayoutPanel_PolskaDzien.TabIndex = 2;
            // 
            // tabPage4_Kolejne3Dni
            // 
            this.tabPage4_Kolejne3Dni.Location = new System.Drawing.Point(4, 24);
            this.tabPage4_Kolejne3Dni.Name = "tabPage4_Kolejne3Dni";
            this.tabPage4_Kolejne3Dni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4_Kolejne3Dni.Size = new System.Drawing.Size(1164, 352);
            this.tabPage4_Kolejne3Dni.TabIndex = 5;
            this.tabPage4_Kolejne3Dni.Text = "Kolejne3Dni";
            this.tabPage4_Kolejne3Dni.UseVisualStyleBackColor = true;
            // 
            // button1_GenerateNext3Days
            // 
            this.button1_GenerateNext3Days.Location = new System.Drawing.Point(506, 68);
            this.button1_GenerateNext3Days.Name = "button1_GenerateNext3Days";
            this.button1_GenerateNext3Days.Size = new System.Drawing.Size(272, 23);
            this.button1_GenerateNext3Days.TabIndex = 6;
            this.button1_GenerateNext3Days.Text = "Generuj Adobe Premiere Suma Kolejne 3 dni";
            this.button1_GenerateNext3Days.UseVisualStyleBackColor = true;
            this.button1_GenerateNext3Days.Click += new System.EventHandler(this.button1_GenerateNext3Days_Click);
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 483);
            this.Controls.Add(this.panel_middle);
            this.Controls.Add(this.panel1_footer);
            this.Name = "ClientPanel";
            this.Text = "Form1";
            this.panel1_footer.ResumeLayout(false);
            this.panel_middle.ResumeLayout(false);
            this.tabControl_Kolejne3Dni.ResumeLayout(false);
            this.tabPage1_OpolszczyznaNoc.ResumeLayout(false);
            this.tabPage1_OpolszczyznaNoc.PerformLayout();
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.ResumeLayout(false);
            this.tabPage2_Opolszczyzna_Dzien_Przed_Poludniem.PerformLayout();
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.ResumeLayout(false);
            this.tabPage3_Opolszczyzna_Dzien_Po_Poludniu.PerformLayout();
            this.tabPage5_PolskaDzien.ResumeLayout(false);
            this.tabPage5_PolskaDzien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1_footer;
        private System.Windows.Forms.Panel panel1_leftSidebar;
        private System.Windows.Forms.Panel panel_middle;
        private System.Windows.Forms.TabControl tabControl_Kolejne3Dni;
        private System.Windows.Forms.TabPage tabPage1_OpolszczyznaNoc;
        private System.Windows.Forms.TabPage tabPage3_Opolszczyzna_Dzien_Po_Poludniu;
        private System.Windows.Forms.TabPage tabPage5_PolskaDzien;
        private System.Windows.Forms.Button button1_PobierzPogode;
        public System.Windows.Forms.TabPage tabPage2_Opolszczyzna_Dzien_Przed_Poludniem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem;
        public System.Windows.Forms.CheckedListBox checkedListBox_WeatherParts;
        public System.Windows.Forms.CheckedListBox checkedListBox_Days;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_OpolszczyznaNoc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_PolskaDzien;
        private System.Windows.Forms.Button button1_GenerateNext3Days;
        private System.Windows.Forms.Button button_GenerateAdobe;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.TabPage tabPage4_Kolejne3Dni;
    }
}
