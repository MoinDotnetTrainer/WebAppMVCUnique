using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppMVCUnique.Models
{
    [HtmlTargetElement("button-helper")]
    public class myBtnTaghelper : TagHelper
    {
        public string Text { get; set; } = "Button";
        public string Type { get; set; } = "button";
        public string CssClass { get; set; } = "btn btn-danger";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("type", Type);
            output.Attributes.SetAttribute("class", CssClass);
            output.Content.SetContent(Text);
        }
    }
}
