using System.ComponentModel.DataAnnotations;

namespace Sample.Entity
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
    }
}
