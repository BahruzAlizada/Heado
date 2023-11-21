using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;


namespace DataAccessLayer.EntityFramework
{
    public class EFTestimonialDal : EfRepositoryBase<Testimonial, Context>, ITestimonialDal
    {
        public void Activity(int id)
        {
            using var context = new Context();

            Testimonial testimonial = context.Testimonials.SingleOrDefault(x=>x.Id==id);
            if (testimonial.Status)
                testimonial.Status = false;
            else
                testimonial.Status = true;

            context.SaveChanges();
        }
    }
}
