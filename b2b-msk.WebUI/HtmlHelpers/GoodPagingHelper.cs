﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Web.Mvc;
using b2b_msk.WebUI.Models;


namespace b2b_msk.WebUI.HtmlHelpers
{
    public static class GoodPagingHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
                                             GoodPagingInfo pagingInfo,
                                             Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }


    }
}