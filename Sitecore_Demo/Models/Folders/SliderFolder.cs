using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore_Demo.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore_Demo.Models.Folders
{
    [SitecoreType(TemplateId = "{216CB0F8-D12F-40D5-862D-BBA2D71EFFA2}",AutoMap =true)]
    public class SliderFolder
    {
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<SliderItems> SlidetItems { get; set; }
    }
}