using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    class MyClass
    {
        private void MyMethod()
        {
            Point point = new ()
            {
                X = 10,
                Y = 20
            };

            point.X = 11; // Not immutable :(
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }



    // Remove set and create constructor is a solution but then you have to use parameters instead of initialization

    //// C# 9 
    //data class Point
    //{
    //    public int X { get; init; }
    //    public int Y { get; init; }
    //}

    //Point otherPoint = point with
    //{
    //    Y = 30;
    //}
}
