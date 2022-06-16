using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphisim
{
    class Book: Product
    {
        public string Author;
        public string Genre;

        public override string GetInfo()
        {
            return $"Name: {Name}- Author: {Author} - Genre: {Genre} - Price: {Price}";
        }
    }
}
