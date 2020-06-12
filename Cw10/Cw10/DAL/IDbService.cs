using Cw10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.DAL
{
    public interface IDbService
    {
        IEnumerable<Student> GetStudents();

        Boolean AddStudent(Student student);

        Boolean UpdateStudent(String id);

        Boolean DeleteStudent(Student student);

        IEnumerable<Student> GetStudent(string id);

        IEnumerable<Enrollment> GetEnrollments(string id, int semester);

    }
}
