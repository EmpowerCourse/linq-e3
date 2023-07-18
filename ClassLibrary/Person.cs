using ClassLibrary.Enums;

namespace ClassLibrary
{
    public class Person
    {
        private readonly int _age;       // private field
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TypeOfGender Gender { get; set; }    // this is an enum
        public string FullName => $"{FirstName} {LastName}";
        public IList<Person> Friends { get; set; }

        /* 
           This is the constructor of the Person class. To create a Person object, you would do: Person foo = new Person("Halie", "Chmura", 24);
           You can then access the value of the firstName field by doing: string fname = foo.FirstName;
           However, you cannot directly access "age" from outside this class since it is a private field (i.e., you cannot do: int age = foo.Age;).
           To access a private variable you can create a public method that returns the age (see GetAge below)
        */
        public Person(string firstName, string lastName, int age, TypeOfGender gender)
        {
            this.FirstName = firstName;         // using 'this' keyword represents the current instance of the Person class. Not necessary to use here
            LastName = lastName;
            Friends = new List<Person>();
            Gender = gender;
            _age = age;
        }

        /*
         * public is the access modifier
         * int is the return type (ie GetAge will be returning an integer)
         * GetAge is the name of the method
         */
        public int GetAge()         
        {
            return _age;
        }

        public void SetFriendsWithAgeRestriction(IList<Person> friends, int minAge, int maxAge)
        {
            // TOOD: implement me 
            // Hint: use LINQ 'Where' for filtering

        }

    }
}