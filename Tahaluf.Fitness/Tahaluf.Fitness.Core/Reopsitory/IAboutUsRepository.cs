using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IAboutUsRepository
    {
        bool CreateAboutUs(AboutUs aboutUs);
        bool UpdateAboutUs(AboutUs aboutUs);
        bool DeleteAboutUs(int id);
        List<AboutUs> GetAboutUs();

    }
}
