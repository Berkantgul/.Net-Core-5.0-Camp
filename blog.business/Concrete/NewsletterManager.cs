using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterRepository _newsletterRepository;
        public NewsletterManager(INewsletterRepository newsletterRepository)
        {
            _newsletterRepository = newsletterRepository;
        }
        public void SubscribeMail(Newsletter entity)
        {
            _newsletterRepository.Insert(entity);
        }
    }
}