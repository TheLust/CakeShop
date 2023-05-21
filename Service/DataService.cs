using CakeShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Service
{
    public class DataService
    {
        private readonly DbRepository db;

        public DataService()
        {
            db = new DbRepository();
        }

        // ProductType CRUD operations

        public List<ProductType> GetAllProductTypes()
        {
            return db.ProductTypes.ToList();
        }

        public void AddProductType(ProductType productType)
        {
            db.ProductTypes.Add(productType);
            db.SaveChanges();
        }

        public void UpdateProductType(ProductType productType)
        {
            var existingProductType = db.ProductTypes.Find(productType.Id);
            if (existingProductType != null)
            {
                existingProductType.Name = productType.Name;
                db.SaveChanges();
            }
        }

        public void DeleteProductType(int productTypeId)
        {
            var productType = db.ProductTypes.Find(productTypeId);
            if (productType != null)
            {
                db.ProductTypes.Remove(productType);
                db.SaveChanges();
            }
        }

        // Color CRUD operations

        public List<Color> GetAllColors()
        {
            return db.Colors.ToList();
        }

        public void AddColor(Color color)
        {
            db.Colors.Add(color);
            db.SaveChanges();
        }

        public void UpdateColor(Color color)
        {
            var existingColor = db.Colors.Find(color.Id);
            if (existingColor != null)
            {
                existingColor.Name = color.Name;
                db.SaveChanges();
            }
        }

        public void DeleteColor(int colorId)
        {
            var color = db.Colors.Find(colorId);
            if (color != null)
            {
                db.Colors.Remove(color);
                db.SaveChanges();
            }
        }

        // Ingredient CRUD operations

        public List<Ingredient> GetAllIngredients()
        {
            return db.Ingredients.ToList();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            db.Ingredients.Add(ingredient);
            db.SaveChanges();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            var existingIngredient = db.Ingredients.Find(ingredient.Id);
            if (existingIngredient != null)
            {
                existingIngredient.Name = ingredient.Name;
                db.SaveChanges();
            }
        }

        public void DeleteIngredient(int ingredientId)
        {
            var ingredient = db.Ingredients.Find(ingredientId);
            if (ingredient != null)
            {
                db.Ingredients.Remove(ingredient);
                db.SaveChanges();
            }
        }

        // Product CRUD operations

        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = db.Products.Find(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.ProductType = product.ProductType;
                existingProduct.Mass = product.Mass;
                existingProduct.Color = product.Color;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
                db.SaveChanges();
            }
        }

        public void DeleteProduct(int productId)
        {
            var product = db.Products.Find(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

        // ProductIngredient CRUD operations

        public List<ProductIngredient> GetAllProductIngredients()
        {
            return db.ProductIngredients.ToList();
        }

        public void AddProductIngredient(ProductIngredient productIngredient)
        {
            db.ProductIngredients.Add(productIngredient);
            db.SaveChanges();
        }

        public void UpdateProductIngredient(ProductIngredient productIngredient)
        {
            var existingProductIngredient = db.ProductIngredients.Find(productIngredient.Id);
            if (existingProductIngredient != null)
            {
                existingProductIngredient.Product = productIngredient.Product;
                existingProductIngredient.Ingredient = productIngredient.Ingredient;
                existingProductIngredient.Quantity = productIngredient.Quantity;
                db.SaveChanges();
            }
        }

        public void DeleteProductIngredient(int productIngredientId)
        {
            var productIngredient = db.ProductIngredients.Find(productIngredientId);
            if (productIngredient != null)
            {
                db.ProductIngredients.Remove(productIngredient);
                db.SaveChanges();
            }
        }

        // ProductType methods

        public ProductType FindProductTypeById(int id)
        {
            return db.ProductTypes.Find(id);
        }

        public ProductType FindProductTypeByName(string name)
        {
            return db.ProductTypes.FirstOrDefault(pt => pt.Name == name);
        }

        // Color methods

        public Color FindColorById(int id)
        {
            return db.Colors.Find(id);
        }

        public Color FindColorByName(string name)
        {
            return db.Colors.FirstOrDefault(c => c.Name == name);
        }

        // Ingredient methods

        public Ingredient FindIngredientById(int id)
        {
            return db.Ingredients.Find(id);
        }

        public Ingredient FindIngredientByName(string name)
        {
            return db.Ingredients.FirstOrDefault(i => i.Name == name);
        }

        // Product methods

        public Product FindProductById(int id)
        {
            return db.Products.Find(id);
        }

        public Product FindProductByName(string name)
        {
            return db.Products.FirstOrDefault(p => p.Name == name);
        }

        // ProductIngredient methods

        public ProductIngredient FindProductIngredientById(int id)
        {
            return db.ProductIngredients.Find(id);
        }
    }
}
