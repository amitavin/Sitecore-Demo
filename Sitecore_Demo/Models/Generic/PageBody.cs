using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore_Demo.Models.Generic
{
    [SitecoreType(TemplateId = "{CB596E4B-A9F0-44B9-88F8-96DC130408BC}", AutoMap = true)]
    public interface PageBody
    {
        [SitecoreField("Page Title")]
        string PageTitle { get; set; }

        [SitecoreField("Body Text")]
        string PageBodyText { get; set; }
    }
}