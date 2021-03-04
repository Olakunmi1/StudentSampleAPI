using StudentSampleAPI.ReadDTO;
using System;
using System.Collections.Generic;

namespace StudentSampleAPI.Student.DataAcces.Interface
{
    public interface IStudent
    {
        List<StudentDTO> GetListOfAllStudentsWhoSubmittedOnASpecificDate();

        List<StudentDTO> GetListOfAllStudentsOrderedByDateOfSubmission();

        void AddCustomer(Student student);
      
    }
}
