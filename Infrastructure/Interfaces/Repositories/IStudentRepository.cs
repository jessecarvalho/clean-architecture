using Core.Entities;

namespace Infrastructure.Interfaces.Repositories;

public interface IStudentRepository
{
    
    public IEnumerable<Student> GetAll();
    public Student? GetById(int id);
    public Student Add(Student student);
    public Student? Update(Student student);
    public bool? Delete(int id);

}