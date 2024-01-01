using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyInjection
{
    public class KernelFactory
    {
        public static T GetService<T>()
        {
            var kernel = new StandardKernel(new DependencyInjection());
            return kernel.Get<T>();
        }
    }
}
