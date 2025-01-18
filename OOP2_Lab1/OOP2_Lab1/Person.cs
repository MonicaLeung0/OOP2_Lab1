using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP2_Lab1
{
    internal class Person
    {
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColor { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }
        string Name;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="personId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="favoriteColor"></param>
        /// <param name="age"></param>
        /// <param name="isWorking"></param>
        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
            Name = firstName + " " + lastName;
            
        }

        /// <summary>
        /// print out info
        /// </summary>
        public void DisplayPersonInfo() 
        {
            Console.WriteLine($"{personId}: {Name}’s favorite colour is: {favoriteColor}");
        }
        /// <summary>
        /// changes the person’s favorite colour to white
        /// </summary>
        public void ChangeFavoriteColour() 
        {
           
            this.favoriteColor = "White";

        }
        /// <summary>
        /// get the person’s age after 10 years
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public void GetAgeInTenYears() 
        {
            
            int changedAge = age + 10;
            Console.WriteLine($"{Name}’s Age in 10 years is: {changedAge}");
        }

        /// <summary>
        /// displays all Person Object information as a list
        /// </summary>
        public void ToStringMethod() 
        {
            
            List<string> target = new List<string>();
            target.Add($"PersonId: {this.personId.ToString()}");
            target.Add($"FirstName: {this.firstName}");
            target.Add($"LastName: {this.lastName}");
            target.Add($"FavoriteColour: {this.favoriteColor}");
            target.Add($"Age: {this.age.ToString()}");
            target.Add($"IsWorking: {this.isWorking.ToString()}");

            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(target[i]);
            }
            
            
        }
    }
}
