using System.Reflection.Metadata;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Clean.Site.Models
{
    public class NavigationViewModel
    {
public String? HomeURL {get;set;}
public IEnumerable<NavigationItem>? NavigationItems {get;set;}
    }
}