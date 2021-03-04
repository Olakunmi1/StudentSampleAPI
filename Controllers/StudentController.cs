using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentSampleAPI.Helpers;
using StudentSampleAPI.ReadDTO;
using StudentSampleAPI.Student.DataAcces.Interface;

namespace StudentSampleAPI.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [Authorize] //https://localhost:5001/connect/token forToken

        [HttpGet("GetListOfAllStudentsWhoSubmittedOnASpecifiDate")]
        public IActionResult GetListOfStudents()
        {
            try
            {
                var students = _student.GetListOfAllStudentsWhoSubmittedOnASpecificDate();

                return Ok(new ApiGenericResponse<StudentDTO>
                {
                    Success = true,
                    Message = "List Of Students Who Submitted On A Specific date",
                    Results = students

                });
            }

            catch(Exception ex)
            {
                //log

                return Ok(new ApiGenericResponse<string>
                {
                    Success = false,
                    Message = "Something went wrong Please try again"
                });
            }
        }

        [HttpGet("GetListOfAllStudentsOrderedByDateOfSubmission")]
        public IActionResult GetListOfStudents_orderByDate()
        {
            try
            {
                var students = _student.GetListOfAllStudentsOrderedByDateOfSubmission();

                return Ok(new ApiGenericResponse<StudentDTO>
                {
                    Success = true,
                    Message = "List Of Students Ordered By Date Of Submission",
                    Results = students
                });
            }

            catch(Exception ex)
            {
                //log into a textFile

                return Ok(new ApiGenericResponse<string>
                {
                    Success = false,
                    Message = "Something went wrong Please try again"
                });
            }
        }

    }
}
