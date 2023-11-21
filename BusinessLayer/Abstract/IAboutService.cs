using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;


namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        About GetAbout();
        Task<About> GetAboutByIdAsync(int? id);
        Task UpdateAsync(AboutDto aboutDto);
    }
}
