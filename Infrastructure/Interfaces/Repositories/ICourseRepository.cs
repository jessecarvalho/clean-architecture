using Core.Entities;

namespace Infrastructure.Interfaces.Repositories;

public interface ICourseRepository
{

    public IEnumerable<Course> GetAll();
    public Course? GetById (int id);
    public Course Add(Course course);
    public Course? Update(Course course);
    public bool? Delete(int id);

}