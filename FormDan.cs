using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR07
{
    public partial class FormDan : Form
    {
        public FormDan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            label1.Text = "Текущее время: " + currentTime.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDan form2 = new FormDan();
            form2.Show(); //возвращаемся на предыдущую форму
            this.Close();
        }
    }
}
