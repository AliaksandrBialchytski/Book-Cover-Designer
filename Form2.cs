using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progr_Graf_Winforms_Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            InitializeComponent();
            if (lang == "ru")
                this.Text = "Настройки текста...";
            rightRadioButton.CheckedChanged += radioButtons_Changed;
            LeftRadioButton.CheckedChanged += radioButtons_Changed;
            CenterRadioButton.CheckedChanged += radioButtons_Changed;
        }
        private void radioButtons_Changed(object sender, EventArgs e)
        {
            if(rightRadioButton.Checked)
            {
                this.textBox1.TextAlign = HorizontalAlignment.Right;
            }
            else if(LeftRadioButton.Checked)
            {
                this.textBox1.TextAlign = HorizontalAlignment.Left;
            }
            else
            {
                this.textBox1.TextAlign = HorizontalAlignment.Center;
            }
        }
        public HorizontalAlignment GetAlign()
        {
            return this.textBox1.TextAlign;
        }
        public string GetText()
        {
            return this.textBox1.Text;
        }
        public int GetSize()
        {
            return (int) this.numericUpDown1.Value;
        }
    }
}
