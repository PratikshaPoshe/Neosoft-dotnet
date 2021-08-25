using System;

namespace Constructor 
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear) //parametrized constructor
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        // Overloading of Constructor:
        // As simlilar to Methods Constructor can be also overloaded by using reference type!
        public Car(int modelYear, string modelName, string modelColor) //parametrized constructor
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

    }
}
