using Kentico.PageBuilder.Web.Mvc;
using KenticoCommunity.BingMapsWidget;
using System.Configuration;
using System.Web.Mvc;

[assembly: RegisterWidget("KenticoCommunity.BingMapsWidget", typeof(BingMapsWidgetController), "Bing Maps widget", Description = "Shows Bing map", IconClass = "icon-brand-bing")]

namespace KenticoCommunity.BingMapsWidget
{
    public class BingMapsWidgetController : WidgetController<BingMapsWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();
            var viewModel = new BingMapsWidgetViewModel
            {
                Latitude = properties.Latitude,
                Longitude = properties.Longitude,
                ZoomInitial = properties.ZoomInitial
            };
            viewModel.ApiKey = ConfigurationManager.AppSettings["BingMapsApiKey"];

            return PartialView("Widgets/KenticoCommunity/BingMapsWidget/_BingMapsWidget", viewModel);
        }
    }
}