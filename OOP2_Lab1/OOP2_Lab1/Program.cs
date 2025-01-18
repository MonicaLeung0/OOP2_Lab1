// See https://aka.ms/new-console-template for more information
using OOP2_Lab1;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;
using static OOP2_Lab1.Relation;

//create objects according to the data
Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
Person Gina = new Person(2, "Gina", "James", "Green", 18, true);
Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

//create list
List<Person> personList = [Ian, Gina, Mike, Mary];

//print info
Gina.DisplayPersonInfo();
Mike.ToStringMethod();
Ian.ChangeFavoriteColour();
Ian.DisplayPersonInfo();
Mary.GetAgeInTenYears();

//print relationship info
Relation sisterRelation = new Relation(Relation.RelationshipType.Sister);
sisterRelation.ShowRelationShip(Gina, Mary);

Relation brotherRelation = new Relation(Relation.RelationshipType.Brother);
brotherRelation.ShowRelationShip(Ian, Mike);

//print addtion info
double sum = 0;
string youngest = "";
string oldest = "";
int olderAge=0;
int youngerAge=50;
List<Person> MNameList = new List<Person>();
List<Person> loveBlueList = new List<Person>();

for (int i = 0; i < personList.Count; i++) 
{
    sum += personList[i].age;
    if (personList[i].age> olderAge) 
    {
        olderAge = personList[i].age;
        oldest = personList[i].firstName;
    }
    if (personList[i].age < youngerAge)
    {
        youngerAge = personList[i].age;
        youngest = personList[i].firstName;
    }

    if (personList[i].firstName.StartsWith("M")) 
    {
        MNameList.Add(personList[i]);
    }

    if (personList[i].favoriteColor.Equals("Blue"))
    {
        loveBlueList.Add(personList[i]);
    }



}

double average = sum / personList.Count;

Console.WriteLine("Average age is: "+ average);
Console.WriteLine("The youngest person is: " + youngest);
Console.WriteLine("The oldest person is: " + oldest);

if (MNameList.Count != 0) 
{
    for (int i = 0; i < MNameList.Count; i++)
    {

        MNameList[i].ToStringMethod();
    }
}
if (loveBlueList.Count != 0)
{
    for (int i = 0; i < loveBlueList.Count; i++)
    {

        loveBlueList[i].ToStringMethod();
    }
}



