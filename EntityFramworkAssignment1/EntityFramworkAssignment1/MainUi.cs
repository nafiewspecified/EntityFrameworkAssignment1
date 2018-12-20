using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramworkAssignment1
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            new CategoryUI().ShowDialog();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            new CustomerUI().ShowDialog();
        }
    }
}
