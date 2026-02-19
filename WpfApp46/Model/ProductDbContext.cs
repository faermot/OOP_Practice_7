using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp46.Model
{
    public class ProductDbContext : DbContext
    {
        #region Конструктор
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public свойства
        public DbSet<Product> Products {  get; set; }
        #endregion

        #region Методы
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts() => new Product[]
        {
            new Product
            {
                ProductID = 1,
                ProductName = "Видеокарта Palit GeForce RTX 5090 GameRock OC",
                ProductDescription = "[NE75090S19R5-GB2020G]",
                ProductPrice = 350999,
                ProductUnit = 20
            },
            
            new Product
            {
                ProductID = 2,
                ProductName = "Видеокарта ASUS GeForce RTX 5080 ROG Astral WHITE OC Edition",
                ProductDescription = "[ROG-ASTRAL-RTX5080-O16G-WHITE]",
                ProductPrice = 199999,
                ProductUnit = 15
            },
            
            new Product
            {
                ProductID = 3,
                ProductName = "Видеокарта GIGABYTE GeForce RTX 5060 Ti WINDFORCE OC ",
                ProductDescription = "[GV-N506TWF2OC-8GD]",
                ProductPrice = 41999,
                ProductUnit = 33
            },
            
            new Product
            {
                ProductID = 4,
                ProductName = "Видеокарта GIGABYTE GeForce RTX 5060 Ti WINDFORCE MAX OC",
                ProductDescription = "[GV-N506TWF2MAX OC-8GD]",
                ProductPrice = 43999,
                ProductUnit = 11
            },

        };
        #endregion
    }
}
