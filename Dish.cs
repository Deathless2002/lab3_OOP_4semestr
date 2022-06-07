using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public  class Dish
    {
        public string Name;
        //public string[]? Ingredients;
        public int Cents;
        public int Dollar;
        public int Weight;
        public string Type;

        public virtual void ShowInList(DataGridView dgv)
        {

        }
        public virtual void ShowForEditEdition(Form2 Form2)
        {

        }
        public virtual void Edit(Form2 Form2)
        {

        }



    }
}
