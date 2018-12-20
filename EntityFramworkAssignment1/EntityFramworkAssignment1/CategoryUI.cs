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
    public partial class CategoryUI : Form
    {
        public CategoryUI()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ProjectDbContext _db =new ProjectDbContext();
            try
            {
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    categoryLabel.Text = "Please Give The Category Name!!";
                    categoryLabel.ForeColor = Color.Red;
                    NameTextBox.Focus();
                    return;
                }

                categoryLabel.Text = "";
                string name = NameTextBox.Text;
                Category category=new Category();
                category.Name = name;
                _db.Categories.Add(category);
               int isSaved=Convert.ToInt32(_db.SaveChanges());
                if (isSaved>0)
                {
                    categoryLabel.Text = "Data Saved Successfully!";
                    categoryLabel.ForeColor = Color.Green;
                    NameTextBox.Text = "";
                    NameTextBox.Focus();
                }
                else
                {
                    categoryLabel.Text = "Fail!";
                    categoryLabel.ForeColor=Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            categoryLabel.Text = "";
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            //categoryLabel.Text = "";
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           categoryLabel.Text = "";
        }
    }
}
