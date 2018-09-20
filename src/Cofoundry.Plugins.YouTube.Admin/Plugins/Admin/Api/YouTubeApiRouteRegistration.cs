using Cofoundry.Web;
using Cofoundry.Web.Admin;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cofoundry.Plugins.YouTube.Admin
{
    public class YouTubeApiRouteRegistration : IRouteRegistration
    {
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder
                .ForAdminApiController<YouTubeSettingsApiController>("plugins/youtube-settings")
                .MapGet();
        }
    }
}
