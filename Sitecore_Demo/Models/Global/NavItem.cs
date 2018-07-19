using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore_Demo.Models.Folders.Global
{

    [SitecoreType(TemplateId = "{0789CB21-3FFC-4730-9A34-7DFB3121F33A}", AutoMap = true)]
    public interface NavItem
    {
        [SitecoreField("Title")]
        string NavText { get; set; }

        [SitecoreField("Link")]
        Link NavLink { get; set; }
    }
}