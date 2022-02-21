using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Animal 
    {
        protected string race;
        protected int age { get; set; }
        protected int height;

        public virtual void noise()
        {
            Console.WriteLine("odglos...");
        }

        public string getRace() // READ
        {
            return this.race;
        }

        public void setRace(string race) // WRITE
        {
            this.race = race;
        }

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}
    }
}
