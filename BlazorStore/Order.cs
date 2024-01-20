using Microsoft.EntityFrameworkCore;

namespace BlazorStore
{
    public class Order
    {
        public DateTime DateCreate { get; set; }
        public decimal Summ { get; set; }
        public required List<Item> Items { get; set; }

        //List<Item> order = new List<Item> { };
        //public void AddOrder(List<Item> listItem)
        //{
        //    order = listItem;   
        //}
        
        public static List<Order> orderList = new List<Order> { };



    }
}
