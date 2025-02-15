using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boba.Interface;
using boba.Models;

namespace boba
{
    internal class Array : ISort
    {
        public List<Human> HumanList { get; set; }
        public void SortASC()
        {
            HumanList = HumanList.OrderBy(h => h.RabNumber).ToList();
            
        }

        public void SortByParam(bool Orden)
        {
            if (Orden)
            {
                SortASC();
            }
            else
            {
                SortDESC();
            }
            
        }

        public void SortDESC()
        { 
            HumanList = HumanList.OrderByDescending(h => h.RabNumber).ToList();
           
        }
    }
    
    
}
