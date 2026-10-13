using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.Cryptography;

namespace WebAppMVCUnique.Models
{
    [HtmlTargetElement("MyHeading")]
    public class HeadingTag : TagHelper
    {
        public int Level { get; set; } = 1;
        public string Text { get; set; } = "Hello World";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {


            // Heading tag
            // h1 to h6

            //<h1>Some Text</h1>
            if (Level < 1 || Level > 6)
            {
                Level = 1;
            }

            output.TagName = $"h{Level}";
            output.TagMode = TagMode.StartTagAndEndTag;
            if (!string.IsNullOrEmpty(Text))
            {
                output.Content.SetContent(Text);
            }

        }
    }
}
