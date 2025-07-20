using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Title")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Minimum 3 letters required")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please Enter Content")]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please Enter Valid Date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
