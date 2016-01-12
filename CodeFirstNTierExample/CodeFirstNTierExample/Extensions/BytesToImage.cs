using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
    public static class BytesToImage
    {
        public static IHtmlString ToImageTag<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, byte[] array, string Id)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.MergeAttribute("id", Id);
            var base64 = Convert.ToBase64String(array);
            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
            tb.MergeAttribute("src", imgSrc);
            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}