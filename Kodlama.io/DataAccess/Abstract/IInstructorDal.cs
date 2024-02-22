using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IInstructorDal
{
    public List<Instructor> GetAll();
    public Instructor GetById(int id);
    public void Add(Instructor Instructor);
    public void Update(Instructor Instructor);
    public void Delete(Instructor Instructor);
}
