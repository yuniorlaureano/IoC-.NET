using Autofac;
using AutoFacNetCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacNetCore.Models
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AutoFacTry>().As<ITryAutoFac>();
        }
    }
}
