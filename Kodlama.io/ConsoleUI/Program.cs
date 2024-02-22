using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
        CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
        InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());

        Category category = new Category();
        Instructor instructor = new Instructor();

        foreach (var course in courseManager.GetAll())
        {
            category = categoryManager.GetById(course.CategoryId);
            instructor = instructorManager.GetById(course.InstructorId);
            Console.WriteLine("Kurs Adı : {0}\nKategori : {1}\nEğitmen  : {2}\n\n----------------------------------------\n", course.Name, category.Name, instructor.FirstName + " " + instructor.LastName);
        }
    }
}