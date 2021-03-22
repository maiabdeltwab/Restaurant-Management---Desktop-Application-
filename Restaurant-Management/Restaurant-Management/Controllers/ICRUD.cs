using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.ViewModel
{
    internal interface ICRUD<T, TV>
    {
        List<TV> ViewAll();

        List<TV> Search(string searchTxt);

        bool Delete(int id);

        bool Update(T user);

        bool Insert(T user);
    }
}