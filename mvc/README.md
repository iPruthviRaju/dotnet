
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




Question 3: Explain MVC application life cycle?

Answer: Any web application has two main execution steps, first understanding the request and depending on the type of the request sending out appropriate response. MVC application life cycle is not different it has two main phases, first creating the request object and second sending our response to the browser.

Creating the request object:

The request object creation has four major steps. The following is the detailed explanation of the same.

Step 1: Fill route

MVC requests are mapped to route tables which in turn specify which controller and action to be invoked. So if the request is the first request the first thing is to fill the route table with routes collection. This filling of route table happens in the global.asax file.

Step 2: Fetch route

Depending on the URL sent “UrlRoutingModule” searches the route table to create “RouteData” object which has the details of which controller and action to invoke.

Step 3: Request context created

The “RouteData” object is used to create the “RequestContext” object.

Step 4: Controller instance created 

This request object is sent to “MvcHandler” instance to create the controller class instance. Once the controller class object is created it calls the “Execute” method of the controller class.
