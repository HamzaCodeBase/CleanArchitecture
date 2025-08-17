using Application.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        RelationshipsDbContext _context;
        public StudentRepository(RelationshipsDbContext context)
        {
            _context = context;
        }
        public ICollection<Student> GetStudents()
        {
            var result1 =  _context.Students.ToList();
            return result1;

        }
    }
}
