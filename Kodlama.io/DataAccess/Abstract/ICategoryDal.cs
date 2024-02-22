using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICategoryDal
{
    public List<Category> GetAll();
    public Category GetById(int id);
    public void Add(Category category);
    public void Update(Category category);
    public void Delete(Category category);
}
