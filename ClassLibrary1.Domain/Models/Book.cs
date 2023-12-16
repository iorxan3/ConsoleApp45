using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Domain.Models
{
    public class Book : Product
    {
        public string AuthorName;
        public int PageCount;

        public Book(string name, int price, int count,string authorname,int pagecount) : base(name, price, count)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }

        public override void Sell()
        {
            if (Count == 0)
            {
                Console.WriteLine("stokda yoxdur");
            }
            else
            {
                Count--;
                gelir += Price;
            }
        }

        public override string ShowInfo()
        {
            return AuthorName +" "+PageCount+" "+Name+" "+Price+" "+Count ;  
        }
    }
}
