using Cofoundry.Domain;
using Cofoundry.Plugins.YouTube.Domain;
using System.ComponentModel.DataAnnotations;

namespace YouTubeExample;

public class YouTubeVideoDataModel : IPageBlockTypeDataModel, IPageBlockTypeDisplayModel
{
    [Required]
    [YouTube]
    public YouTubeVideo Video { get; set; }
}
