using CakeShop.Data;
using CakeShop.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = CakeShop.Data.Color;

namespace CakeShop
{
    public partial class Main : Form
    {
        DataService service;
        Product toUpdate;
        int productId;
        public Main()
        {
            InitializeComponent();
            service = new DataService();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            showProducts();
            updateBtn.Hide();
            addBtn.Show();
        }

        private string getIngredients(int prodId)
        {
            string sg = "";
            foreach(ProductIngredient pi in service.GetAllProductIngredients())
            {
                if (pi.Product == prodId)
                    sg += pi.Ingredient1.Name + " " + pi.Quantity + " ";
            }

            return sg;
        }

        private void showProducts()
        {
            typeCB.Items.Clear();
            colorCB.Items.Clear();
            productDataGridView.Columns.Clear();
            ingredientGB.Visible = false;
            productGB.Visible = true;

            nameTB.Text = "";
            typeCB.Text = "";
            massTB.Text = "";
            colorCB.Text = "";
            priceTB.Text = "";
            stockTB.Text = "";

            foreach (ProductType pd in service.GetAllProductTypes())
            {
                typeCB.Items.Add(pd.Name);
            }

            foreach (Color color in service.GetAllColors())
            {
                colorCB.Items.Add(color.Name);
            }

            var products = (from p in service.GetAllProducts()
                            select new
                            {
                                Product = p.Name,
                                Type = p.ProductType1.Name,
                                Color = p.Color1.Name,
                                Price = p.Price,
                                Mass = p.Mass,
                                Stock = p.Stock,
                                Ingredients = getIngredients(p.Id)
                            });

            productDataGridView.DataSource = products.ToList();
            productDataGridView.Columns[0].Visible = true;

            productDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = CakeShop.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });

            productDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = CakeShop.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void showIngredients()
        {
            ingredientCB.Items.Clear();
            productDataGridView.Columns.Clear();
            ingredientCB.Text = "";
            quantityTB.Text = "";
            ingredientGB.Visible = true;

            foreach (Ingredient ingredient in service.GetAllIngredients())
            {
                ingredientCB.Items.Add(ingredient.Name);
            }

            var ingredients = (from pi in service.GetAllProductIngredients()
                               where pi.Product == productId
                               select new
                               {
                                   ID = pi.Id,
                                   Ingredient = pi.Ingredient1.Name,
                                   Quantity = pi.Quantity
                               });

            productDataGridView.DataSource = ingredients.ToList();
            productDataGridView.Columns[0].Visible = false;

            productDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = CakeShop.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "deleteIng"
            });
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB.Text))
            {
                MessageBox.Show("Name cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(typeCB.Text))
            {
                MessageBox.Show("Type cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(massTB.Text))
            {
                MessageBox.Show("Mass cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(colorCB.Text))
            {
                MessageBox.Show("Color cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(priceTB.Text))
            {
                MessageBox.Show("Price cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(stockTB.Text))
            {
                MessageBox.Show("Stock cannot be null or whitespace!");
                return;
            }

            toUpdate.Name = nameTB.Text;
            toUpdate.ProductType = service.FindProductTypeByName(typeCB.Text).Id;
            toUpdate.Mass = Convert.ToInt32(massTB.Text);
            toUpdate.Color = service.FindColorByName(colorCB.Text).Id;
            toUpdate.Price = Convert.ToInt32(priceTB.Text);
            toUpdate.Stock = Convert.ToInt32(stockTB.Text);

            try
            {
                service.UpdateProduct(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            productId = toUpdate.Id;
            updateBtn.Hide();
            addBtn.Show();
            showIngredients();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB.Text))
            {
                MessageBox.Show("Name cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(typeCB.Text))
            {
                MessageBox.Show("Type cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(massTB.Text))
            {
                MessageBox.Show("Mass cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(colorCB.Text))
            {
                MessageBox.Show("Color cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(priceTB.Text))
            {
                MessageBox.Show("Price cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(stockTB.Text))
            {
                MessageBox.Show("Stock cannot be null or whitespace!");
                return;
            }

            Product product = new Product()
            {
                Name = nameTB.Text,
                ProductType = service.FindProductTypeByName(typeCB.Text).Id,
                Mass = Convert.ToInt32(massTB.Text),
                Color = service.FindColorByName(colorCB.Text).Id,
                Price = Convert.ToInt32(priceTB.Text),
                Stock = Convert.ToInt32(stockTB.Text),
            };

            try
            {
                service.AddProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            productId = service.FindProductByName(product.Name).Id;
            showIngredients();
        }

        private void massTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Check if the entered character is not a digit and not a backspace
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        private void priceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Check if the entered character is not a digit and not a backspace
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        private void stockTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Check if the entered character is not a digit and not a backspace
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                toUpdate = service.FindProductByName(productDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                updateBtn.Show();
                addBtn.Hide();
                nameTB.Text = toUpdate.Name;
                typeCB.Text = toUpdate.ProductType1.Name;
                massTB.Text = toUpdate.Mass.ToString();
                colorCB.Text = toUpdate.Color1.Name;
                priceTB.Text = toUpdate.Price.ToString();
                stockTB.Text = toUpdate.Stock.ToString();
            }

            if (e.ColumnIndex == 8)
            {
                try
                {
                    foreach (ProductIngredient pi in service.GetAllProductIngredients())
                    {
                        if (pi.Product == service.FindProductByName(productDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Id)
                            service.DeleteProductIngredient(pi.Id);
                    }
                    service.DeleteProduct(service.FindProductByName(productDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                showProducts();
            }

            if (productDataGridView.Columns[e.ColumnIndex].Name.Equals("deleteIng"))
            {
                try
                {
                    service.DeleteProductIngredient((int)productDataGridView.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); return;
                }
                showIngredients();
            }
        }

        private void addIngredientBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ingredientCB.Text))
            {
                MessageBox.Show("Ingredient cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(quantityTB.Text))
            {
                MessageBox.Show("Quantity cannot be null or whitespace!");
                return;
            }

            ProductIngredient productIngredient = new ProductIngredient()
            {
                Product = productId,
                Ingredient = service.FindIngredientByName(ingredientCB.Text).Id,
                Quantity = Convert.ToInt32(quantityTB.Text)
            };

            try
            {
                service.AddProductIngredient(productIngredient);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showIngredients();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            showProducts();
        }

        private void quantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Check if the entered character is not a digit and not a backspace
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        private void tasksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks tasks= new Tasks();
            tasks.ShowDialog();
            this.Show();
        }
    }
}
