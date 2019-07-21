
using System.Collections.Generic;
using System.Linq;

namespace Personal2Project.Data
{
    public class ProductModel
    {

        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {

                new Product
                {
                    Id = "p01",
                    Name = "name 1",
                    Price = 55.99,
                    Photo = "coveralbum4.jpg"
                },
                new Product
                {
                    Id = "p02",
                    Name = "name 2",
                    Price = 55.99,
                    Photo = "coveralbum3.jpg"
                },
                new Product
                {
                    Id = "p03",
                    Name = "name 3",
                    Price = 38.99,
                    Photo = "albumcover1.jpg"
                },
                new Product
                {
                    Id = "p04",
                    Name = "name 4",
                    Price = 47.99,
                    Photo = "albumcover2.jpg"
                }

            };

        }

        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
