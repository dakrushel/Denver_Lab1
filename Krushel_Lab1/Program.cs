using Krushel_Lab1;

namespace Krushel_Lab1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            
            List<Person> persList = new List<Person>() {ian, gina, mike, mary};
            
            float ageTotal = 0;
            foreach (Person pers in persList)
            {
                ageTotal += pers.age;
            }

            int lowestAge = persList[0].age;
            int lowestAgeTracker = 0;
            int highestAge = persList[0].age;
            int highestAgeTracker = 0;
            for (int i = 1; i < persList.Count; i++)
            {
                if (persList[i].age < lowestAge)
                {
                    lowestAge = persList[i].age;
                    lowestAgeTracker = i;
                }
                else if (persList[i].age > highestAge)
                {
                    highestAge = persList[i].age;
                    highestAgeTracker = i;
                }
            }

            Console.WriteLine(gina.DisplayPersonInfo());
            Console.WriteLine(mike.ToString());
            ian.ChangeFavoriteColor();
            Console.WriteLine(ian.DisplayPersonInfo());
            Console.WriteLine(mary.GetAgeInTenYears());
            Relation r1 = new Relation(gina, mary, "Sisterhood");
            Relation r2 = new Relation(ian, mike, "Brotherhood");
            Console.WriteLine(r1.ShowRelationship(gina, mary));
            Console.WriteLine(r2.ShowRelationship(ian, mike));
            Console.WriteLine($"\nAverage age is {ageTotal / persList.Count}\n");
            Console.WriteLine($"The youngest person is: {persList[lowestAgeTracker].firstName}");
            Console.WriteLine($"The oldest person is: {persList[highestAgeTracker].firstName}");
            
            List<Person> mNames = new List<Person>();
            foreach (Person pers in persList)
            {
                if (pers.firstName.ToUpper().StartsWith("M"))
                {
                    mNames.Add(pers);
                    Console.WriteLine(pers.ToString());
                }
            }

            List<Person> likesBlue = new List<Person>();
            foreach (Person pers in persList)
            {
                if (pers.favoriteColor.ToUpper() == "BLUE")
                {
                    likesBlue.Add(pers);
                    Console.WriteLine(pers.ToString());
                }
            }
        }
    }
}
