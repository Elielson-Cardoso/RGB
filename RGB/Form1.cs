using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
            lblRed.Text = trackRed.Value.ToString();
            lblGreen.Text = trackGreen.Value.ToString();
            lblBlue.Text = trackBlue.Value.ToString();
            txtRGB.Text =  trackRed.Value.ToString() + ";" + trackGreen.Value.ToString() + ";" + trackBlue.Value.ToString();
        }    
    }
}
