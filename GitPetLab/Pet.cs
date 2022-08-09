using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPetLab
{
    internal abstract class Pet
    {
        public string Name { get; set; }

        public int Birthdate { get; set; }


        public int Age { get; set; }

        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
