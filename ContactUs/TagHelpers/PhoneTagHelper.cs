using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ContactUs.TagHelpers
{
    [HtmlTargetElement("call", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class PhoneTagHelper : TagHelper
    {
        public string PhoneNumber { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"tel:{PhoneNumber}");
            output.Content.AppendHtml($"Call {PhoneNumber}");

            base.Process(context, output);
        }
    }
}
