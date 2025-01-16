// See https://aka.ms/new-console-template for more information
using OOP2_Lab1;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
Person Gina = new Person(2, "Gina", "James", "Green", 18, true);
Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

Gina.DisplayPersonInfo();
Mike.ToStringMethod();
Ian.ChangeFavoriteColour();
Ian.DisplayPersonInfo();
Mary.GetAgeInTenYears();

Relation relation = new Relation();





