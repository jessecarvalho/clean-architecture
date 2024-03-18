using Core.Enums;

namespace Core.Entities;

public record Course
{
    public int Id { get; init; }
    public string Title { get; set; }
    public string Description { get; set; }
    public CourseYearEnum Year { get; set; }
    public List<Student>? Students { get; set; }
    
    public Course(int id, string title, string description, CourseYearEnum year)
    {
        Id = id;
        Title = title;
        Description = description;
        Year = year;
        Students = new List<Student>();
    }
    
}