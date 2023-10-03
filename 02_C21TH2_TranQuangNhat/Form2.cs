using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_C21TH2_TranQuangNhat
{
    public partial class Form2 : Form
    {
        public string maSV { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            masv.Text = maSV;
        }
    }
}
