using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicBack.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
