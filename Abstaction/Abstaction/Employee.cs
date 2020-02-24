using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        IQuittable n = new IQuittable();
        n.Quit();

    }
}
