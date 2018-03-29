using Cofoundry.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cofoundry.Plugins.YouTube.Domain
{
    public class YouTubeSettings : PluginConfigurationSettingsBase
    {
        public string ApiKey { get; set; }
    }
}
