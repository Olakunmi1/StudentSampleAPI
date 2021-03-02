using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSampleAPI.Student.DataAcces
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        public int Age { get; set; }

        [ForeignKey("AssignmentId")]
        public IEnumerable<Assignment> Assignment { get; set; }

        public int AssignmentId { get; set; }

        public DateTime Created_at { get; set; }
    }
        
    
}
