using Entities.Abstract;

namespace Entities.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CoverImage { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }

    public Instructor Instructor { get; set; }
    public Category Category { get; set; }
}
