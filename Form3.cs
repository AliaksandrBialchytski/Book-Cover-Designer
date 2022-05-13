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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            InitializeComponent();
            if (lang == "ru")
                this.Text = "Новая обложка";
        }
        public int GetCoverWidth()
        {
            return (int) this.numericUpDown1.Value;
        }
        public int GetCoverHeight()
        {
            return (int)this.numericUpDown2.Value;
        }
        public int GetSpineWidth()
        {
            return (int)this.numericUpDown3.Value;
        }
    }
}
