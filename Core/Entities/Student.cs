namespace Core.Entities;

public record class Student
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public List<Course>? Courses { get; set; }

    public Student()
    {
        Courses = new List<Course>();
    }
    
    public Student(int id, string name, string email, string username, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        UserName = username;
        Password = password;
        Courses = new List<Course>();
    }
    
}