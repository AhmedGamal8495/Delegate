using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Journalist
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Action<Journalist> _add;

        public event Action<Journalist> AddNews
        {
            add { _add += value; }
            remove { _add -= value; }
        }

        public void Add()
        {
            Console.WriteLine("Adding....");
            if(_add != null)
                _add(this);
        }


        
    }
}
