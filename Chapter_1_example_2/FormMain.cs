using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_1_example_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.Text = "Приведствие";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            btnClick.Text= "Ты уже стал волком";
            MessageBox.Show("Салам Аллейкум!");
        }

        private void markFIO_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Ты уже волк?");
        }
    }
}
