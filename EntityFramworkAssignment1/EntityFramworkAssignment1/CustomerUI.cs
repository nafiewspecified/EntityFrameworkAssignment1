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
        private readonly ProjectDbContext _db;
        public CustomerUI()
        {
            InitializeComponent();
            _db=new ProjectDbContext();
        }
       
        private void CustomerUI_Load(object sender, EventArgs e)
        {
            var category = _db.Categories.ToList();
            categoryVMBindingSource.DataSource = null;
            categoryVMBindingSource.DataSource = category;
            //categoryVMBindingSource.DataSource = _db.Categories;
            //CategoryCombobox.DataSource = categoryVMBindingSource;
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = new List<Product>();
                var customer=new Customer();
                customer.Name = NameTextBox.Text;
                customer.ContactNo = ContactNoTextBox.Text;
                customer.Address = AddressTextBox.Text;
                if (!maleRadioButton.Checked && !femaleRadioButton.Checked && !otherRadioButton.Checked)
                {
                    genderLabel.Text = "Check Gender!!";
                    genderLabel.ForeColor=Color.Red;
                    return;
                }

                if (maleRadioButton.Checked)
                {
                    customer.Gender = maleRadioButton.Text;
                }
                else if(femaleRadioButton.Checked)
                {
                    customer.Gender = femaleRadioButton.Text;
                }
                else if (otherRadioButton.Checked)
                {
                    customer.Gender = otherRadioButton.Text;
                }

                //for checkBox
//                if (computerCheckbox.Checked || upsCheckBox.Checked || airConditionCheckBox.Checked || FreezeCheckBox.Checked)
//                {
//                    var product1 = new Product() { Name = computerCheckbox.Text };
//                    products.Add(product1);
//                }

                if (computerCheckbox.Checked && upsCheckBox.Checked && airConditionCheckBox.Checked &&
                    FreezeCheckBox.Checked)
                {
                    var product1 = new Product() { Name = computerCheckbox.Text };
                    var product2 = new Product() { Name = upsCheckBox.Text };
                    var product3 = new Product() { Name = airConditionCheckBox.Text };
                    var product4 = new Product() { Name = FreezeCheckBox.Text };
                    products.Add(product1);
                    products.Add(product2);
                    products.Add(product3);
                    products.Add(product4);
                }
                else if (computerCheckbox.Checked && upsCheckBox.Checked && airConditionCheckBox.Checked)
                {
                    var product1 = new Product() { Name = computerCheckbox.Text };
                    var product2 = new Product() { Name = upsCheckBox.Text };
                    var product3 = new Product() { Name = airConditionCheckBox.Text };
                    products.Add(product1);
                    products.Add(product2);
                    products.Add(product3);
                }
                else if(computerCheckbox.Checked&&upsCheckBox.Checked)
                {
                    var product1 = new Product() { Name = computerCheckbox.Text };
                    var product2 = new Product() { Name = upsCheckBox.Text };
                    products.Add(product1);
                    products.Add(product2);
                }
                else if (airConditionCheckBox.Checked && FreezeCheckBox.Checked)
                {
                    var product1 = new Product() { Name = airConditionCheckBox.Text };
                    var product2 = new Product() { Name = FreezeCheckBox.Text };
                    products.Add(product1);
                    products.Add(product2);
                }

              
               
                
                customer.ProductList = products;
                _db.Customers.Add(customer);
                var isAdded = _db.SaveChanges();
                if (isAdded > 0)
                {
                    customerLabel.Text = "DataSaved Successfully!";
                    customerLabel.ForeColor = Color.Green;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
