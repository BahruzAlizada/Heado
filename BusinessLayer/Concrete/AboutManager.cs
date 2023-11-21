using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;


namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal aboutDal;
        private readonly IMapper mapper;
        public AboutManager(IAboutDal aboutDal,IMapper mapper)
        {
            this.aboutDal= aboutDal;
            this.mapper= mapper;
        }


        public About GetAbout()
        {
            return aboutDal.Get();
        }

        public async Task<About> GetAboutByIdAsync(int? id)
        {
            return await aboutDal.GetAsync(x=>x.Id == id);
        }

        public async Task UpdateAsync(AboutDto aboutDto)
        {
            About about = mapper.Map<About>(aboutDto);
            await aboutDal.UpdateAsync(about);
        }
    }
}
