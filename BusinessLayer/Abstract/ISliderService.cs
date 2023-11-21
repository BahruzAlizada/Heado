using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;

namespace BusinessLayer.Abstract
{
    public interface ISliderService
    {
        Slider GetSlider();
        Slider GetSliderById(int? id);
        void Add(SliderDto sliderDto);
        void Update(SliderDto sliderDto);
    }
}
