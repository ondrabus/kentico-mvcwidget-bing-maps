using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace KenticoCommunity.BingMapsWidget
{
    public class BingMapsWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Latitude")]
        public string Latitude { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Longitude")]
        public string Longitude { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Initial zoom")]
        public int ZoomInitial { get; set; } = 10;
    }
}