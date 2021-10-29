namespace RGB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackRed = new MetroFramework.Controls.MetroTrackBar();
            this.trackBlue = new MetroFramework.Controls.MetroTrackBar();
            this.trackGreen = new MetroFramework.Controls.MetroTrackBar();
            this.lblRed = new MetroFramework.Controls.MetroLabel();
            this.lblBlue = new MetroFramework.Controls.MetroLabel();
            this.lblGreen = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRGB = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackRed
            // 
            this.trackRed.BackColor = System.Drawing.Color.Transparent;
            this.trackRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trackRed.Location = new System.Drawing.Point(57, 118);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(285, 23);
            this.trackRed.Style = MetroFramework.MetroColorStyle.Red;
            this.trackRed.TabIndex = 1;
            this.trackRed.Value = 0;
            this.trackRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeColor);
            // 
            // trackBlue
            // 
            this.trackBlue.BackColor = System.Drawing.Color.Transparent;
            this.trackBlue.Location = new System.Drawing.Point(57, 202);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(285, 23);
            this.trackBlue.Style = MetroFramework.MetroColorStyle.Green;
            this.trackBlue.TabIndex = 2;
            this.trackBlue.Value = 0;
            this.trackBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeColor);
            // 
            // trackGreen
            // 
            this.trackGreen.BackColor = System.Drawing.Color.Transparent;
            this.trackGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trackGreen.Location = new System.Drawing.Point(57, 160);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(285, 23);
            this.trackGreen.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackGreen.TabIndex = 3;
            this.trackGreen.Value = 0;
            this.trackGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeColor);
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(351, 118);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(45, 23);
            this.lblRed.TabIndex = 7;
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Location = new System.Drawing.Point(351, 202);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(45, 23);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(351, 160);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(45, 23);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(57, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 100);
            this.panel1.TabIndex = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtRGB);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.lblGreen);
            this.metroPanel1.Controls.Add(this.trackRed);
            this.metroPanel1.Controls.Add(this.lblBlue);
            this.metroPanel1.Controls.Add(this.trackBlue);
            this.metroPanel1.Controls.Add(this.lblRed);
            this.metroPanel1.Controls.Add(this.trackGreen);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(409, 269);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(2, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Green:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Blue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Red:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel4.Location = new System.Drawing.Point(110, 237);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "RGB:";
            // 
            // txtRGB
            // 
            // 
            // 
            // 
            this.txtRGB.CustomButton.Image = null;
            this.txtRGB.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txtRGB.CustomButton.Name = "";
            this.txtRGB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRGB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRGB.CustomButton.TabIndex = 1;
            this.txtRGB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRGB.CustomButton.UseSelectable = true;
            this.txtRGB.CustomButton.Visible = false;
            this.txtRGB.Lines = new string[0];
            this.txtRGB.Location = new System.Drawing.Point(150, 237);
            this.txtRGB.MaxLength = 32767;
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.PasswordChar = '\0';
            this.txtRGB.ReadOnly = true;
            this.txtRGB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRGB.SelectedText = "";
            this.txtRGB.SelectionLength = 0;
            this.txtRGB.SelectionStart = 0;
            this.txtRGB.ShortcutsEnabled = true;
            this.txtRGB.Size = new System.Drawing.Size(122, 23);
            this.txtRGB.TabIndex = 12;
            this.txtRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRGB.UseSelectable = true;
            this.txtRGB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRGB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RGB.Properties.Resources.download;
            this.BackImage = global::RGB.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(449, 349);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Definição de Cores RGB";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTrackBar trackRed;
        private MetroFramework.Controls.MetroTrackBar trackBlue;
        private MetroFramework.Controls.MetroTrackBar trackGreen;
        private MetroFramework.Controls.MetroLabel lblRed;
        private MetroFramework.Controls.MetroLabel lblBlue;
        private MetroFramework.Controls.MetroLabel lblGreen;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtRGB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

