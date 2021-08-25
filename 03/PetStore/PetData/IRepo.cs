using System.Collections.Generic;
using System.Threading.Tasks;
namespace PetData
{
    public interface IRepo
    {
        //IEnumerable<Cat> Init();
        void Add(Cat cat);
        // void Delete(int cat);
        IEnumerable<Cat> GetAllCats(string path= @"Cats.xml");
        ]Cat GetCat(int id);
        // Cat GetCat(string name);
    }
}