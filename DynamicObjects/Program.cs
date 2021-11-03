using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicObjects
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // The first option we have for true dynamic objects is a class called ExpandoObject.
            // This class is effectively just Dictionary<string, object> but it also implements IDynamicMetObjectProvider
            // which defines how the dynamic type system should look up members like properties and methods at run-time, producing very clean syntax shown below
            
            dynamic expando = new ExpandoObject();
            expando.Name = "Tiffany";
            expando.Age = 30;
            expando.GoBackInTime = new Action(() => expando.Age--);

            expando.GoBackInTime();
            Console.WriteLine(expando.Age);
            
            // ExpandoObject implements IDictionary<string, object> though it does so "implicitly".
            // That means if you case an ExpandoObject to IDictionary<string, object> you can do some additional cool things like enumerate all members that an ExpandoObject currently has or even delete a member:
            
            IDictionary<string, object> expandoAsDictionary = (IDictionary<string, object>)expando;

            foreach (var memberName in expandoAsDictionary.Keys)
            {
                Console.WriteLine(memberName);
            }

            expandoAsDictionary.Remove("Age"); // Remove the 'Age' property
        }
    }
}