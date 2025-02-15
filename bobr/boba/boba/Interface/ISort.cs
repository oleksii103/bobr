using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boba.Interface
{
    
    public interface ISort
    {
        void SortASC();
        void SortDESC();

        void SortByParam(bool Orden);
    }
}
