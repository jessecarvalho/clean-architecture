using Core.Entities;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class CourseRepository : ICourseRepository
{

    protected readonly ApplicationDbContext _context;

    public CourseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Course> GetAll()
    {
        return _context.Courses;
    }

    public Course? GetById(int id)
    {
        var course = _context.Courses.Find(id);

        return course;
    }

    public Course Add (Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
        return course;
    }

    public Course? Update (Course course)
    {
        var courseInDb = _context.Courses.Find(course.Id);

        if (courseInDb == null)
        {
            return null;
        }

        courseInDb.Title = course.Title;
        courseInDb.Description = course.Description;
        courseInDb.Year = course.Year;
        courseInDb.Students = course.Students;

        _context.SaveChanges();

        return courseInDb;
    }

    public bool? Delete(int id)
    {
        var course = _context.Courses.Find(id);

        if (course == null)
        {
            return null;
        }

        _context.Courses.Remove(course);
        _context.SaveChanges();
        return true;
    }
    
    

}