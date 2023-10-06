using InterpreterDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.FilterExpression
{
    public class ParseQuery
    {
        public IProductExpression Parse(string input)
        {
            var criteria = input.Split(';');
            var expressions = new List<IProductExpression>();

            foreach (var criterion in criteria)
            {
                var parts = criterion.Trim().Split(':');
                if (parts[0] == "brand")
                {
                    expressions.Add(new BrandFilterExpression(parts[1].Trim()));
                }
                else if (parts[0] == "color")
                {
                    expressions.Add(new ColorFilterExpression(parts[1].Trim()));
                }
                else if (parts[0] == "minprice")
                {
                    decimal minPrice = decimal.Parse(parts[1]);
                    expressions.Add(new PriceFilterExpression(minPrice, decimal.MaxValue));
                }
                else if (parts[0] == "maxprice")
                {
                    decimal maxPrice = decimal.Parse(parts[1]);
                    expressions.Add(new PriceFilterExpression(decimal.MinValue, maxPrice));
                }
            }

            return new CompoundFilterExpression(expressions.ToArray());
        }
    }
}
