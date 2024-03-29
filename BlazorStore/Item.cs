﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorStore
{
    public class Item
    {
        public int Id { get; set; }
        public required string imgPath { get; set; }
        public string Name { get; set; }
        public required string Description { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }

        public static List<Item> items = new List<Item>()
        {
            new Item {Id=1, Name = "Игрушка1", imgPath = "700.jpg", Description="Новогодняя поделка", Price = 500, Quantity = 12 },
            new Item {Id=2, Name = "Игрушка2", imgPath = "400.jpg", Description="Дракон", Price = 300, Quantity = 5 },
            new Item {Id=3, Name = "Игрушка3", imgPath = "701.jpg", Description="Новогодняя поделка", Price = 200, Quantity = 65 },
            new Item {Id=4, Name = "Игрушка4", imgPath = "1600.jpg", Description="Новогодняя поделка", Price = 300, Quantity = 9 },
        };
        
        public static List<Item> cart = new List<Item>()
        {
        };
        public static Item itemDescr = new Item { Id = 0, Name = "", imgPath = "", Description = "", Price = 0, Quantity = 0 };

        public static List<Item> itemsDb = new List<Item>()
        {
            new Item {Id=1, Name = "Игрушка1DB", imgPath = "700.jpg", Description="Новогодняя поделка", Price = 500, Quantity = 12 },
            new Item {Id=2, Name = "Игрушка2DB", imgPath = "400.jpg", Description="Дракон", Price = 300, Quantity = 5 },
            new Item {Id=3, Name = "Игрушка3DB", imgPath = "701.jpg", Description="Новогодняя поделка", Price = 200, Quantity = 65 },
            new Item {Id=4, Name = "Игрушка4DB", imgPath = "1600.jpg", Description="Новогодняя поделка", Price = 300, Quantity = 9 },
        };

        async Task LoadItems()
        {
            var options = new DbContextOptionsBuilder<AppDBContext>()
                .UseSqlite("Data Source=catalogItems.db").Options;
            using (var dbContext = new AppDBContext(options))
            {
                itemsDb = await dbContext.Items.ToListAsync();
            }
        }




    }
}
