using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StudentSampleAPI.ReadDTO;
using StudentSampleAPI.Student.DataAcces;
using StudentSampleAPI.Student.DataAcces.Interface;

namespace StudentSampleAPI.Student.Services
{
    public class StudentRepo : IStudent
    {
        private readonly ApplicationDbContext _context;

        public StudentRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(DataAcces.Student student)
        {
            _context.Students.Add(student);
        }

        public List<StudentDTO> GetListOfAllStudentsOrderedByDateOfSubmission()
        {
            var collections = _context.Assignments as IQueryable<DataAcces.Assignment>;
            collections = collections.Include(t => t.Student)
                                     .OrderBy(t => t.DateOfSubmission);
            collections.ToList();

            var listOfstudents_ReadDTO = collections
                      .Select(x => new StudentDTO
                      {
                          Name = x.Student.Name,
                          Age = x.Student.Age,
                          Created_at = x.Student.Created_at
                      }).ToList();

            return listOfstudents_ReadDTO;
        }

        public List<StudentDTO> GetListOfAllStudentsWhoSubmittedOnASpecificDate()
        {
            var CorrectDeadLine = new DateTime(2021, 02, 28); //AssumedCorrectDeadLine

            var collections = _context.Assignments as IQueryable<DataAcces.Assignment>;
            collections = collections.Include(t => t.Student)
                                     .Where(t => t.DateOfSubmission == CorrectDeadLine);

            //var collections = _context.Assignments.Include(t => t.Student)
            //                         .Where(t => t.DateOfSubmission == CorrectDeadLine)
            //                         .FirstOrDefault().Student.Name;

            var listOfstudents_ReadDTO = collections
                       .Select(x => new StudentDTO
                       {
                           Name = x.Student.Name,
                           Age = x.Student.Age,
                           Created_at = x.Student.Created_at
                       }).ToList();

            return listOfstudents_ReadDTO;
        }
    }
}
