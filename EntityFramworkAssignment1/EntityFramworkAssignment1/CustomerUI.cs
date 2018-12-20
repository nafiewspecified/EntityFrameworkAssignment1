using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF.Models;

namespace EntityFramworkAssignment1
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }
        ProjectDbContext _db=new ProjectDbContext();
        private void CustomerUI_Load(object sender, EventArgs e)
        {
            categoryVMBindingSource.DataSource = null;
            //categoryVMBindingSource.DataSource = _db.Categories;
           // CategoryCombobox.DataSource = categoryVMBindingSource
        }
    }
}
