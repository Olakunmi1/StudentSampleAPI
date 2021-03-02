using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<DataAcces.Assignment> GetListOfAllStudentsOrderedByDateOfSubmission()
        {
            var collections = _context.Assignments as IQueryable<DataAcces.Assignment>;
            collections = collections.Include(t => t.Student)
                                     .OrderBy(t => t.DateOfSubmission);
            collections.ToList();
            return collections;
        }

        public IEnumerable<DataAcces.Assignment> GetListOfAllStudentsWhoSubmittedOnASpecificDate()
        {
            var CorrectDeadLine = new DateTime(2021, 02, 28); //AssumedCorrectDeadLine
            var collections = _context.Assignments as IQueryable<DataAcces.Assignment>;
            collections = collections.Include(t => t.Student)
                                     .Where(t => t.DateOfSubmission == CorrectDeadLine);
            collections.ToList();
            return collections;
        }
    }
}
