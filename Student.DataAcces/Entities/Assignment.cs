using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSampleAPI.Student.DataAcces
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public int StudentId { get; set; }

        [Required]
        public DateTimeOffset DateOfSubmission { get; set; }

    }
}
