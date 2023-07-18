using ClassLibrary.Enums;
using ClassLibrary;
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Person p0 = new Person("Chris", "Jackson", 31, TypeOfGender.Male);
            Person p1 = new Person("Halie", "Chmura", 24, TypeOfGender.Female);
            Person p2 = new Person("Dane", "Cook", 32, TypeOfGender.Male);
            Person p3 = new Person("Jesse", "Bessoir", 30, TypeOfGender.Male);
            Person p4 = new Person("John", "Crowley", 33, TypeOfGender.Male);
            Person p5 = new Person("Jane", "Doe", 18, TypeOfGender.Other);
            Person p6 = new Person("John", "Doe", 48, TypeOfGender.Other);


            // 1. Put Chris' last name into the following variable:
            string chrisLastName = "";      // TODO: replace "" with Chris' last name
            Console.WriteLine(chrisLastName);
            Console.WriteLine("---------------------------");



            // 2. Put Chris' age into the following variable (why can't we directly access _age like we did lastName above?):
            int chrisAge = 0;   // TODO: replace 0 with Chris' age
            Console.WriteLine(chrisAge);
            Console.WriteLine("---------------------------");



            /* 3. 
                 Fill out the method named SetFriendsWithAgeRestriction in the Person class.
                 The method takes in a list of Person objects, an integer representing minimum age, and an integer representing maximum age
                 This method should filter the friends to everyone within the age restriction, and then set the Friends field to that list 
            */

            IList<Person> friends = new List<Person> { p1, p2, p3, p4, p5, p6 };
            p0.SetFriendsWithAgeRestriction(friends, 28, 32);
            PrintPeople(p0.Friends);



            // 4. Create a new Person object with your first name, last name, age, and gender. Add yourself to Chris' current Friend list
            // hint: Lists in C# have a method 'Add' that adds an element to a list

            // TODO: create new person that represents you
            // TODO: add that person to Chris' friends list

            PrintPeople(p0.Friends);



            // 5. Using LINQ, determine if any of Chris' friends have a last name that begin with a 'C'
            // hint: String class in C# has method called StartsWith that determines if a string starts with a certain letter
            bool hasFriendThatStartsWithC = false; // TODO: replace false with LINQ  
            Console.WriteLine(hasFriendThatStartsWithC);
            Console.WriteLine("---------------------------");


            // 6. Set Chris' friends to his current set of friends but ordered by first name in descending order AND filtered to only people that are male
            // TODO: change Chris' friends here
            PrintPeople(p0.Friends);



            // 7. Create a new method in the Person class that returns an integer and is called SumOfFriendsAges
            // This method should take in no arguments
            // This method should return the sum of the ages of all the Friends

            // TODO: invoke SumOfFriendsAges on Chris object and print out returned value



            // 8. Iterate over each of Chris' friends and print their full name if the friend is under 31
            // TODO: implement here

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for the user to press any key before exiting





        }

        static void PrintPeople(IList<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);     
            }
            Console.WriteLine("---------------------------");
        }
    }
}

          



