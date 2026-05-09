using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Identity2.Helpers.images
{
    public class ImageHelper
    {
        public static IHtmlContent RenderProductImage(string imageUrl, string altText, string cssClass ="img-thumbnail")
        {
            if (string.IsNullOrEmpty(imageUrl))
            {
                imageUrl = "/images/no-image/placeholder.png";
            }
            var imgTag = new TagBuilder("img");
            imgTag.Attributes.Add("src", imageUrl);
            imgTag.Attributes.Add("alt", altText);
            imgTag.AddCssClass(cssClass);
            imgTag.Attributes.Add("style", "max-heignt: 100px; width: auto;");

            return imgTag;
        }
    }
}
