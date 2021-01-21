using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] plateNumbers;
        V[] cities;

        public MyDictionary()
        {
            plateNumbers = new K[0];
            cities = new V[0];
        }
        public void Add(K plateNumber, V city)
        {
            K[] tempPlateNumber = plateNumbers;
            V[] tempCities = cities;

            plateNumbers = new K[plateNumbers.Length + 1];
            cities = new V[cities.Length + 1];

            for (int i = 0; i < tempPlateNumber.Length; i++)
            {
                plateNumbers[i] = tempPlateNumber[i];
                cities[i] = tempCities[i];
            }
            plateNumbers[plateNumbers.Length - 1] = plateNumber;
            cities[cities.Length - 1] = city;
        }

        public K[] PlateNumbers
        {
            get
            {
                return plateNumbers;
            }
        }

        public V[] Cities
        {
            get
            {
                return cities;
            }
        }
        }
}
