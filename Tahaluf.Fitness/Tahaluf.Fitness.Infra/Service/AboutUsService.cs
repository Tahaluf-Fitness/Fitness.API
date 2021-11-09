using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.Infra.Service
{
    public class AboutUsService: IAboutUsService
    {
        private readonly IAboutUsRepository aboutUsRepository;

        public AboutUsService(IAboutUsRepository _aboutUsRepository)
        {
            aboutUsRepository = _aboutUsRepository;
        }
        public bool UpdateAboutUs(AboutUs aboutUs)
        {
            return aboutUsRepository.UpdateAboutUs(aboutUs);
        }

        public bool CreateAboutUs(AboutUs aboutUs)
        {
            return aboutUsRepository.CreateAboutUs(aboutUs);
        }

        public bool DeleteAboutUs(int id)
        {
            return aboutUsRepository.DeleteAboutUs(id);
        }

        public List<AboutUs> GetAboutUs()
        {
            return aboutUsRepository.GetAboutUs();

        }
    }
}
