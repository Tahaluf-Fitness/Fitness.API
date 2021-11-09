using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IAboutUsService
    {
        bool CreateAboutUs(AboutUs aboutUs);
        bool UpdateAboutUs(AboutUs aboutUs);
        bool DeleteAboutUs(int id);
        List<AboutUs> GetAboutUs();
    }
}
