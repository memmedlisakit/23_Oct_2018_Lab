using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogezyApp.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title required")]
        [MaxLength(500)]
        public string Title { get; set; }

        [Required(ErrorMessage = "AddedDate required")] 
        public  DateTime  AddedDate { get; set; }
         

        public string Tag { get; set; }
         
        public ICollection<Comment> Comments { get; set; }

        [Required(ErrorMessage = "Image required")]
        public string Image { get; set; }

        [Required(ErrorMessage = "ShortDescription required")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Details required")]
        public string Details { get; set; }
    }
}
