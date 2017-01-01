using System.Web.Mvc;

namespace DotNetBlog.Areas.DotNetBlog
{
    public class DotNetBlogAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DotNetBlog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DotNetBlog_default",
                "DotNetBlog/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}