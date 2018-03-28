using Cofoundry.Domain;
using Cofoundry.Plugins.YouTube.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeExample
{
    public class YouTubeVideoDataModel : IPageBlockTypeDataModel, IPageBlockTypeDisplayModel
    {
        [Required]
        [YouTube]
        public YouTubeVideo Video { get; set; }
    }
}
