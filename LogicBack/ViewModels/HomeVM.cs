using LogicBack.Models;
using System.Collections.Generic;

namespace LogicBack.ViewModels
{
    public class HomeVM
    {
        public Slider Sliders { get; set; }
        public List<Icon> Icons  { get; set; }
        public About Abouts { get; set; }
        public List<AboutList> AboutLists { get; set; }
        public List<Service> Services { get; set; }
        public Action Actions { get; set; }
        public Setting Settings { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
