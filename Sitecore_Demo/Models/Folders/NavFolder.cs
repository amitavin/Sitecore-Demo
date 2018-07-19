using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore_Demo.Models.Folders.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore_Demo.Models.Folders
{
    [SitecoreType(TemplateId = "{70AA7D8D-B0A4-4CF8-8364-7B92D364588E}",AutoMap =true)]
    public class NavFolder
    {
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<NavItem> NavItems { get; set; }
    }
}