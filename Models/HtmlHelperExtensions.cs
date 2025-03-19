using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Security.Application;
using System.Web.Mvc;
using Ganss.Xss;

namespace AntiXssTest.Models
{
    public static class HtmlHelperExtensions //利用擴充方法，將 Microsoft AntiXSS 和 Ganss.XSS 這兩個套件的功能添加到 HtmlHelper 類別中，讓它可以更方便地用於 ASP.NET MVC 的 View 中。
    {
        // 使用 Microsoft AntiXSS 過濾 HTML
        public static MvcHtmlString AntiXssRaw(this HtmlHelper html, string rawHtml) =>
            MvcHtmlString.Create(Sanitizer.GetSafeHtmlFragment(rawHtml));

        // 使用 Ganss.XSS 來過濾 HTML
        static HtmlSanitizer sanitizer = new HtmlSanitizer();
        public static MvcHtmlString SanitizedRaw(this HtmlHelper html, string rawHtml) =>
            MvcHtmlString.Create(sanitizer.Sanitize(rawHtml));  // 使用 Ganss.XSS 進行過濾

    }
}