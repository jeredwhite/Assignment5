using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem (Book novel, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == novel.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = novel,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public void RemoveLine(Book novel) =>
            Lines.RemoveAll(x => x.Book.BookId == novel.BookId);

        public void Clear() => Lines.Clear();

        public float ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
