﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Registeration.Startup))]
namespace Registeration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
