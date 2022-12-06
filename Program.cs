using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
using System.IO;


namespace WorkingWithCollection


{
    class Program
    {
        static void Main(String[] args)
        {
            Cars vehicle = new Cars();
            vehicle.Make = "Toyota";
            vehicle.Model = "Corolla";
            vehicle.VIN = "A1";


            Cars vehicle1 = new Cars();
            vehicle1.Make = "Land Rover";
            vehicle1.Model = "Defender";
            vehicle1.VIN = "B2";
      


            Books textbook = new Books();
            textbook.Title = "Robert Lightwood";
            textbook.Author = "Microsoft .NET XML Web Services";
            textbook.ISBM = "0-000-00000-0";

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(vehicle);
            myArrayList.Add(vehicle1);

            ArrayList myArrayList2 = new ArrayList();
            myArrayList2.Add(textbook);
            
            //List<T>

            List < Cars > myCarsList = new List<Cars>();
            myCarsList.Add(vehicle);
            myCarsList.Add(vehicle1);
            
            List < Books > myBooksList = new List<Books>();
            myBooksList.Add(textbook);
            
            foreach (Cars car in myCarsList)
            {
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(" ");
            }

            foreach (Books book in myBooksList)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.ISBM);
                Console.WriteLine(" ");
            }
            // Dictionary (TKey key, TValue value)
            Dictionary<string, Cars> myDictionary = new Dictionary<string, Cars>();
             
            myDictionary.Add(vehicle.VIN, vehicle);
            myDictionary.Add(vehicle1.VIN, vehicle1);
            
            Console.WriteLine(myDictionary["A1"].Make);
         


            Console.ReadLine();
            {
                
            }
        }
        class Cars
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
           
        }
        class Books
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBM { get; set; }
        }
        
    }

}