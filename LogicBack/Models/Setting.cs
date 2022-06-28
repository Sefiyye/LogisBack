using System.Collections.Generic;

namespace LogicBack.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string FooterLogo { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
