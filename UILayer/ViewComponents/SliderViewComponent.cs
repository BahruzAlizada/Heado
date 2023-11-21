using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderService sliderService;
        public SliderViewComponent(ISliderService sliderService)
        {
            this.sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            Slider slider = sliderService.GetSlider();
            return View(slider);
        }

    }
}
