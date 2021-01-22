using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{   
    
    class Animal
    {
         public string name;
         public int weight;

        public virtual void Setme(string name , int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public virtual void Show()
        {
            
        }

        
    }


}
