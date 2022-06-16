using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphisim
{
    class Library
    {
        Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }
        public int GetJournalsCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    count++;
                }

            }
            return count;
        }
        public int GetBooksCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Book)
                {
                    count++;
                }

            }

            return count;
        }
        public Product[] GetProducts(bool isBook)
        {
            Product[] products;
            if (isBook)

                products = GetBookProduct();

            else products = GetJournalsProduct();
            return products;


        }

        public Product[] GetBookProduct()
        {
            Product[] books = new Product[0];
            foreach (var item in products)
            {
                if (item is Book)
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = item;
                }

            }
            return books;
        }
        public Product[] GetJournalsProduct()
        {
            Product[] journals = new Product[0];
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    Array.Resize(ref journals, journals.Length + 1);
                    journals[journals.Length - 1] = item;
                }

            }
            return journals;
        }

    }

}
