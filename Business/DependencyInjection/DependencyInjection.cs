﻿using DataAccess.Dal;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyInjection
{
    public class DependencyInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonelDal>().To<PersonelDal>();
            Bind<IPersonelService>().To<PersonelService>();

            
            Bind<IUrunDal>().To<UrunDal>();
            Bind<IUrunService>().To<UrunService>();
            
        }
    }
}
