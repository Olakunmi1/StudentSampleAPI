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

                var listOfstudents_ReadDTO = students
                        .Select(x => new StudentDTO
                        {
                            Name = x.Student.Name,
                            Age = x.Student.Age,
                            Created_at = x.Student.Created_at
                        }).ToList();

                return Ok(new ApiGenericResponse<StudentDTO>
                {
                    Success = true,
                    Message = "List Of Students Who Submitted On A Specific date",
                    Results = listOfstudents_ReadDTO

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

                var listOfstudents_ReadDTO = students
                        .Select(x => new StudentDTO
                        {
                            Name = x.Student.Name,
                            Age = x.Student.Age,
                            Created_at = x.Student.Created_at
                        }).ToList();

                return Ok(new ApiGenericResponse<StudentDTO>
                {
                    Success = true,
                    Message = "List Of Students Ordered By Date Of Submission",
                    Results = listOfstudents_ReadDTO
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
