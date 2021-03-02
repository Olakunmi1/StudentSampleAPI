using System;
using System.Collections.Generic;

namespace StudentSampleAPI.Student.DataAcces.Interface
{
    public interface IStudent
    {
        IEnumerable<Assignment> GetListOfAllStudentsWhoSubmittedOnASpecificDate();

        IEnumerable<Assignment> GetListOfAllStudentsOrderedByDateOfSubmission();

        void AddCustomer(Student student);
      
    }
}
