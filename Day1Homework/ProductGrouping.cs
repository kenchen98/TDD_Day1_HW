using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework
{
    public class ProductGrouping
    {
        public List<Product> GetProductList()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            products.Add(new Product { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            products.Add(new Product { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            products.Add(new Product { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            products.Add(new Product { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            products.Add(new Product { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            products.Add(new Product { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            products.Add(new Product { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            products.Add(new Product { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            products.Add(new Product { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            products.Add(new Product { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            return products;
        }

        /// <summary>
        /// 取得產品幾個一組的加總
        /// </summary>
        /// <param name="count">個數(幾個一組)</param>
        /// <param name="colName">欄位名稱</param>
        /// <returns></returns>
        public decimal[] GetProductSubTotal(int count, string colName)
        {
            List<Product> productList = GetProductList();

            int groupCount = (int)Math.Ceiling((double)productList.Count() / count);
            decimal[] result = new decimal[groupCount];

            for (var i = 0; i < groupCount; ++i)
            {
                result[i] = productList.Skip(i * count).Take(count).Select(x => Convert.ToDecimal(x.GetType().GetProperty(colName).GetValue(x))).Sum();
            }

            return result;
        }
    }
}