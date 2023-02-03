using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class AnimalShelters<T> where T : class, IAnimals, new()
    {
        private const int DefaultPlacesCount = 20;
        public T[] animalList;
        private int usedPlaces;


        public AnimalShelters() : this(DefaultPlacesCount)
        {

        }
        public AnimalShelters(int placesCount)
        {
            this.animalList = new T[placesCount];
            usedPlaces = 0;
        }


        public void Shelter(T newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {

                throw new Exception("Shelter is full");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;

        }

        public T Release(int index)
        {
            if (index < 0 || index >= this.animalList.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid cell index" + index);
            }
            T releasedAnimal = this.animalList[index];
            for (int i = index; i < this.usedPlaces - 1; i++)
            {

                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = null;
            this.usedPlaces++;
            return releasedAnimal;
        }
         

    }
}
