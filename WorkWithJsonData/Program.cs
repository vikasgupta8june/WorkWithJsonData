using System;
using System.Xml;
using Newtonsoft.Json;
//Install-Package Newtonsoft.Json

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample JSON data
            string json = @"{
                'name': 'John Doe',
                'age': 30,
                'isStudent': false,
                'courses': ['Math', 'Science', 'English'],
                'address': {
                    'city': 'New York',
                    'state': 'NY'
                }
            }";

            //Deserialization in C#:
            ///json/XmlAttribute -> c# object
            //Deserialization refers to the process of converting JSON or other serialized data into C# objects, 
            //allowing you to work with the data within your C# application.

            // Deserialize JSON string to an object
            Person person = JsonConvert.DeserializeObject<Person>(json);

            // Display the deserialized object
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("Is Student: " + person.IsStudent);
            Console.WriteLine("Courses:");
            foreach (var course in person.Courses)
            {
                Console.WriteLine("- " + course);
            }
            Console.WriteLine("Address: " + person.Address.City + ", " + person.Address.State);

            // Serialization in C#:
            // c# object -> json/xml
            //Serialization is the process of converting C# objects into JSON or other serialized formats, 
            //making it suitable for storage or transmission, such as saving data to a file or sending it over a network.

            // Serialize an object to JSON
            //output JSON should be formatted with indentation and line breaks for improved readability.
            string serializedJson = JsonConvert.SerializeObject(person, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine("\nSerialized JSON:");
            Console.WriteLine(serializedJson);
        }
    }

    // Define a class to represent the structure of the JSON data
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }
        public string[] Courses { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
    }
}
