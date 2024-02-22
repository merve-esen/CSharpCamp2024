using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public List<Course> GetAllByCategory(int categoryId)
    {
        return _courseDal.GetAllByCategory(categoryId);
    }

    public List<Course> GetAllByInstructor(int instructorId)
    {
        return _courseDal.GetAllByInstructor(instructorId);
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }
}
