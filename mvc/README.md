
Default routing in mvc

public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }


ViewData

ViewData is used to pass data from controller to view.
It is derived from ViewDataDictionary class.
It is available for the current request only.
Requires typecasting for complex data type and checks for null values to avoid error.
If redirection occurs, then its value becomes null.
ViewBag

ViewBag is also used to pass data from the controller to the respective view.
ViewBag is a dynamic property that takes advantage of the new dynamic features in C# 4.0
It is also available for the current request only.
If redirection occurs, then its value becomes null.
Doesn’t require typecasting for complex data type.
TempData

TempData is derived from TempDataDictionary class
TempData is used to pass data from the current request to the next request
It keeps the information for the time of an HTTP Request. This means only from one page to another. It helps to maintain the data when we move from one controller to another controller or from one action to another action
It requires typecasting for complex data type and checks for null values to avoid error. Generally, it is used to store only one time messages like the error messages and validation messages
