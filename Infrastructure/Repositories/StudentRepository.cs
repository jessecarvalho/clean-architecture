using Core.Entities;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    protected readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Student> GetAll()
    {
        return _context.Students;
    }

    public Student? GetById(int id)
    {
        var student = _context.Students.Find(id);

        if (student == null)
        {
            return null;
        }

        return student;
    }

    public Student Add (Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
        return student;
    }

    public Student? Update(Student student)
    {
        var studentInDb = _context.Students.Find(student.Id);

        if (studentInDb == null)
        {
            return null;
        }

        studentInDb.Name = student.Name;
        studentInDb.Email = student.Email;
        studentInDb.UserName = student.UserName;
        studentInDb.Password = student.Password;

        _context.SaveChanges();
        return studentInDb;

    }

    public bool? Delete (int id)
    {
        var student = _context.Students.Find(id);

        if (student == null)
        {
            return null;
        }

        _context.Students.Remove(student);
        _context.SaveChanges();
        return true;
    }
    
}