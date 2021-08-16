using System.Collections.Generic;
namespace PetData
{
    public interface IRepo
    {
        //IEnumerable<Cat> Init();
        void Add(Cat cat);
        // void Delete(int cat);
        IEnumerable<Cat> GetAllCats();
        Cat GetCat(int id);
        // Cat GetCat(string name);
    }
}