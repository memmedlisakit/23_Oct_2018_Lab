using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogezyApp.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Text required")]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required(ErrorMessage = "Post required")]
        public Post Post { get; set; }
         
        public int PostId { get; set; }
    }
}
