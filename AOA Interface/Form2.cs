using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOA_Interface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string classname = "";
        private int starttime = 0;
        private int endtime = 24;
        private int roomno = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new data_preview().Show();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
