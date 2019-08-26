using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlnTest
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<App>().As<IApp>();
            builder.RegisterType<Robot>().As<IRobot>();
            builder.RegisterType<InputReader>().As<IInputReader>();
           
            return builder.Build();
        }
    }
}
