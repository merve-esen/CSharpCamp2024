using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCourseDal : ICourseDal
{
    private List<Course> _courses;

    public InMemoryCourseDal()
    {
        _courses = new List<Course>
        {
            new Course(){ Id = 1, Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", CategoryId = 1, InstructorId = 1 },
            new Course(){ Id = 2, Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", CategoryId = 1, InstructorId = 1 },
            new Course(){ Id = 3, Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", CategoryId = 1, InstructorId = 1 },
            new Course(){ Id = 4, Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", CategoryId = 1, InstructorId = 1 },
            new Course(){ Id = 5, Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA", CategoryId = 1, InstructorId = 1 },
            new Course(){ Id = 6, Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", CategoryId = 1, InstructorId = 2 },
            new Course(){ Id = 7, Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", CategoryId = 1, InstructorId = 1 }
        };
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetById(int id)
    {
        return _courses.SingleOrDefault(c => c.Id == id);
    }

    public List<Course> GetAllByCategory(int categoryId)
    {
        return _courses.Where(c => c.CategoryId == categoryId).ToList();
    }

    public List<Course> GetAllByInstructor(int instructorId)
    {
        return _courses.Where(c => c.InstructorId == instructorId).ToList();
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Update(Course course)
    {
        Course courseToUpdated = _courses.SingleOrDefault(c => c.Id == course.Id);
        courseToUpdated.Name = course.Name;
        courseToUpdated.CategoryId = course.CategoryId;
        courseToUpdated.InstructorId = course.InstructorId;
    }

    public void Delete(Course course)
    {
        Course courseToDeleted = _courses.SingleOrDefault(c => c.Id == course.Id);
        _courses.Remove(courseToDeleted);
    }
}
