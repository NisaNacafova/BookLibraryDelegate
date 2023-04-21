using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Book
    {
        private static int _id;
        public int Id;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
        Predicate<string> Predicate { get; set; }
        public Book(string name,string authorname,int pagecount,decimal price)
        {
            _id++;
            Id= _id;
            Name= name;
            AuthorName= authorname;
            PageCount= pagecount;
            Price= price;
            string[] names = Name.Split(' ');
            foreach (var items in names)
            {
                Code += items[0];
            }
            Code += Id;
        }
        
    }
}
