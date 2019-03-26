using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            // first name
            Console.WriteLine("Please enter a number of students:");
            var theInput = Console.ReadLine();
            int.TryParse(theInput, out int theNumber);

            string[] names = new string[theNumber];


              for (var i = 0; i < names.Length; i++)
              {
                  Console.WriteLine("Please enter a student's first name: ");
                  var nameInput = Console.ReadLine();
                  names[i] = nameInput;

              }


             foreach(string name in names)
          {
              Console.WriteLine($"The names are: {name}");
          }



            string longestName()
          {

              string longest = names[0];
             foreach(string element in names)
              {
                  if (element.Length >= longest.Length)
                  {
                      longest = element;
                  }
              }

              return $"The longest name is {longest}";
          }

         Console.WriteLine( longestName());


          string shortestName() {

              string shortest = names[0];

              foreach (string element in names)
              {

                  if(element.Length <= shortest.Length)
                  {
                      shortest = element; 
                  }
              }

              return $"The shortest name is {shortest}" ;
          }
          Console.WriteLine(shortestName());


          int averageName()
          {
              int average = 0;
              foreach(string element in names)
              {
                 average += element.Length;

              }

              average = average / names.Length;
              return average;
          }

          Console.WriteLine($"The average length is {averageName()}");

          Console.WriteLine("------------------");
          //last name

          for (var i=0; i<names.Length; i++)
          {
              Console.WriteLine("Please enter the student's last name: ");
              string lastNameInput = Console.ReadLine();
              names[i] = lastNameInput;
          }

          foreach(string lastname in names)
          {
              Console.WriteLine($"The last names are: {lastname}");
          }


          string longestLastName()
          {
              string longest = names[0];
              foreach (string lastName in names)
              {
                  if (lastName.Length >= longest.Length)
                  {
                      longest = lastName;

                  }

              }
              return $"The longest last name is {longest}";

          }
          Console.WriteLine(longestLastName());


          void shortestLastName()
          {
              string shortest = names[0];

              foreach (string lastName in names)
              {
                  if(lastName.Length <= shortest.Length)
                  {
                      shortest = lastName;
                  }

              }
              Console.WriteLine($"The shortest last name is {shortest}");
          }
          shortestLastName();


          void averageLastName()
          {
              int average = 0;

              foreach (string lastName in names)
              {
                  average += lastName.Length;
              }
              average = average / names.Length;

              Console.WriteLine($"The average last name length is: {average} ");
          }

          averageLastName();

          Console.WriteLine("------------------");  

            // DATE BIRTH

            DateTime[] birthdayArr = new DateTime[theNumber];

            for (var i = 0; i < birthdayArr.Length; i++)
            {

                Console.WriteLine("Please enter the year of birth: ");
                bool someYear = int.TryParse(Console.ReadLine(), out int theYear);
                Console.WriteLine("Please enter the month of birth: ");
                bool someMonth = int.TryParse(Console.ReadLine(), out int theMonth);
                Console.WriteLine("Please enter the day of birth: ");
                bool someDay = int.TryParse(Console.ReadLine(), out int theDay);

                birthdayArr[i] = new DateTime(theYear, theMonth, theDay);
            }


            foreach (var date in birthdayArr)
            {
                Console.WriteLine($"The dates are {date}");
            }

            Console.WriteLine("------------------");

            // time span

            TimeSpan[] age = new TimeSpan[theNumber];

            var today = DateTime.Now;
            for (int i = 0; i < birthdayArr.Length; i++)
            {
                var timeSpan = today - birthdayArr[i];
                age[i] = timeSpan;
               
            }

            //foreach (var item in age)
            //{
            //    Console.WriteLine($"The rezult is {item}");

            //}

            var theOldest = age[0];

            var theYangest = age[0];

            foreach (var date in age)
            {

                if (date > theOldest)
                {
                    theOldest = date;
                }
                if (date < theYangest)
                {
                    theYangest = date;
                }


            }

            Console.WriteLine("------------------");

            // ova samo time span, ne e age. 
            Console.WriteLine($"The oldest is {theOldest}");
            Console.WriteLine($"The yangest is {theYangest}");



        }
    }
}
