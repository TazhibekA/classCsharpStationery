using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     public partial class Stationery
    {
        private static int id = 0;
        private string name;
        private int cost;
        private static DateTime productedDate;
        private string category;
        private DateTime expirationDate;
        private static int count = 0;

        public Stationery(string name, int cost, DateTime productedDate, string category, DateTime expirationDate)
        {
            this.name = name;
            this.cost = cost;
           
            this.category = category;
            this.expirationDate = expirationDate;
            id++;
            count++;
        }

        static Stationery(){
              productedDate =  DateTime.Now;

        }

        public Stationery(int id, int cost, int count, string name, DateTime productedDate)
        {
            Id = id;
            Cost = cost;
            Count = count;
            Name = name;
            ProductedDate = productedDate;
        }

        public Stationery()
        {
            id++;
            count++;
            cost = 0;
            productedDate = new DateTime(0, 0, 0);
            expirationDate = new DateTime(0, 0, 0);
            category = " ";
            name = " ";
        }

        public int Id { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public DateTime ProductedDate { get; set; }
        
    }
}
