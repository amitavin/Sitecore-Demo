using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;
namespace Sitecore_Demo.Models.Global
{
[SitecoreType(TemplateId = "{36A0175B-035C-4E62-8230-B40646BAF25D}",AutoMap =true)]
    public interface SliderItems
    {
        [SitecoreField("Slider Text")]
        string SliderText { get;set; }

        [SitecoreField("Slider Image")]
        Image SliderImage { get; set; }

        [SitecoreField("Slider Description")]
        string SliderDescription { get; set; }
    }
}