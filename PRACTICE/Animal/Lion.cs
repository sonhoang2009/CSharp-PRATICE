using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Lion : Animal
    {
        public override void Setme(string name, int weight)
        {
            base.Setme(name, weight);
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine("Name : {0} , Weght : {1} ",name,weight);
        }
    }
}
