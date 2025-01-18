using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Lab1
{
    internal class Relation
    {
        public enum RelationshipType
        {
            Sister, Brother, Mother, Father
        }
        RelationshipType relationshipType;
        public Relation(RelationshipType type) 
        {
            this.relationshipType = type;
        }
        /// <summary>
        /// accepts two Person objects and displays the relationship between them
        /// </summary>
        /// <param name="PersonOne"></param>
        /// <param name="PersonTwo"></param>
        public void ShowRelationShip(Person PersonOne, Person PersonTwo) 
        {
            Console.WriteLine($"Relationship between {PersonOne.firstName} and {PersonTwo.firstName} is: {relationshipType}hood");
        }
    }
}
