using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework
{
    public class ProductGrouping
    {
        /// <summary>
        /// 取得產品幾個一組的加總
        /// </summary>
        /// <param name="count">個數(幾個一組)</param>
        /// <param name="colName">欄位名稱</param>
        /// <returns></returns>
        public decimal[] GetProductSubTotal<T>(int count, string colName, List<T> productList)
        {
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