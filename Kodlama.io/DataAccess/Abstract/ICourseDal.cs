using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICourseDal
{
    public List<Course> GetAll();
    public Course GetById(int id);
    List<Course> GetAllByCategory(int categoryId);
    List<Course> GetAllByInstructor(int instructorId);
    public void Add(Course Course);
    public void Update(Course Course);
    public void Delete(Course Course);
}
