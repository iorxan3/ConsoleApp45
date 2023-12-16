using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1.Domain.Models
{
    public abstract class Product
    {
        private int _id; 
        public int Id { get;}
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        private int _gelir;
        protected int gelir { get; set; }
    public Product(string name, int price, int count)
    {
        _id++;
        Id = _id;
        gelir = _gelir;
        Name = name;
        Price = price;
        Count = count;
    }
        public abstract string ShowInfo();
        public abstract void Sell();
    }
    

}
