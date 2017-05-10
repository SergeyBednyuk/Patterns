using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ProductDecorator : IProduct
    {
        protected IProduct product;

        public ProductDecorator(IProduct product)
        {
            this.product = product;
        }

        public double Cost { get; set; }
        public string Name { get; set; }
        public int VenderCode { get; set; }

        public virtual void PrintInfo()
        {
            product.PrintInfo();
        }
    }
}
