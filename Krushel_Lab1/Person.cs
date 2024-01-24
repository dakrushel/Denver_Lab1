using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_Lab1
{
    public class Person
    {
        //Member variables
        public int personID { get; set; }
        public string firstName;
        public string lastName;
        public string favoriteColor;
        public int age;
        public bool isWorking;

        //Ctor
        public Person(int aID, string a1Name, string a2Name, string aColor, int aAge, bool aEmployed)
        {
            personID = aID;
            firstName = a1Name;
            lastName = a2Name;
            favoriteColor = aColor;
            age = aAge;
            isWorking = aEmployed;
            Console.WriteLine($"Person '{this.firstName}' created.");

        }

        //Methods
        public string DisplayPersonInfo()
        {
            return $"{personID}: {this.firstName} {this.lastName}'s favorite color is {favoriteColor}";
        }
        //public string DisplaySentence()
        //{
        //    return $"{this.personID}: {this.firstName} {this.lastName}'s favorite colour is {favoriteColor}";
        //}

        public void ChangeFavoriteColor()
        {
            this.favoriteColor = "white";
        }
        public int GetAgeInTenYears()
        {
            return this.age + 10;
        }
        public override string ToString()
        {
            return $"PersonId: {personID}\nfirst name: {firstName}\nlast name: {lastName}\nfavorite color: {favoriteColor}\nage: {age}\nemployment status: {isWorking}";
        }

        /*
        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }
        */
    }
}
