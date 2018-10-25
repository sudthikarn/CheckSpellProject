using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckSpell
{
    public partial class Form2 : Form
    {
        public Form2(List<DictModel> model)
        {
            InitializeComponent();

            foreach (var item in model)
            {
                listBox1.Items.Add(item.Key + " : " + item.Suggest);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
