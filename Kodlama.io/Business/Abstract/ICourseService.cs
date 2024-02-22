using Entities.Concrete;

namespace Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    Course GetById(int id);
    List<Course> GetAllByCategory(int categoryId);
    List<Course> GetAllByInstructor(int instructorId);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}