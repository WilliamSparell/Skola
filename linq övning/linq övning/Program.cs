namespace linq_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            var people = new Person[]
            {
                new Person{Name="Jack Nicholson",Age=83},
                new Person{Name="Nicholas Cage",Age=56},
                new Person{Name="Bruce Willis",Age=65},
            };

            //var peopleByAge  = from person in people
            //                   orderby person.Age
            //                   select person;
            var peopleByAge = people.OrderBy(x => x.Age);

            


        }
    }
}
