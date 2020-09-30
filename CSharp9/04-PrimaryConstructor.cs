using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }
    }

    // C# 9
    public record SimplePerson(string name);







    //// Original plan
    //class Person
    //{
    //    private string _name;

    //    public Person(string name)
    //    {
    //        _name = name;
    //    }

    //    public string Name
    //    {
    //        get => _name;
    //        set
    //        {
    //            _name = value ?? throw new ArgumentNullException();
    //        }
    //    }
    //}

    //// C# 9
    //class PersonWithPrimaryConstructor(string name)
    //{
    //    public string Name
    //    {
    //        get => name;
    //        set
    //        {
    //            name = value ?? throw new ArgumentNullException();
    //        }
    //    }
    //}
}
