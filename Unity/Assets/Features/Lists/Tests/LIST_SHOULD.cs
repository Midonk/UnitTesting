using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ListSystem;
using NUnit.Framework;
using System.Linq;
using System;

public class LIST_SHOULD
{
    List_ex01 Ex01 = new List_ex01();
    List_ex02 Ex02 = new List_ex02();
    List_ex03 Ex03 = new List_ex03();
    List_ex04 Ex04 = new List_ex04();
    List_ex05 Ex05 = new List_ex05();
    List_ex06 Ex06 = new List_ex06();
    List_ex07 Ex07 = new List_ex07();
    List_ex08 Ex08 = new List_ex08();
    List_ex09 Ex09 = new List_ex09();
    List_ex10 Ex10 = new List_ex10();

    List<Person> classroom;
    List<Module> listModules;
    List<PointObject> objects;
    List<int> listInt;
    List<Product> listProduct1, listProduct2, listProduct3;

    [SetUp]
    public void SetUp()
    {

        listInt =  new List<int>() { 5, 8, 1, 3, 4, 26, 15 };

        classroom = new List<Person>();
        classroom.Add(new Person("Cherif", "Younis", "Sanglier"));
        classroom.Add(new Person("Maxime", "Bellens", "Unknown"));
        classroom.Add(new Person("Robin", "Roekens", "Unknown"));
        classroom.Add(new Person("Herv�", "Chiera", "Unknown"));
        classroom.Add(new Person("Lory", "Colonius", "Unknown"));
        classroom.Add(new Person("Mathieu", "Allard", "Unknown"));
        classroom.Add(new Person("Thomas", "Finet", "Unknown"));
        classroom.Add(new Person("Adrien", "Ideler", "Unknown"));
        classroom.Add(new Person("Kyllian", "Bocklandt", "Unknown"));
        classroom.Add(new Person("Jean", "Mourmeaux", "Unknown"));
        classroom.Add(new Person("Amaury", "Deltenre", "Unknown"));
        classroom.Add(new Person("Cherif", "Younis", "Unknown"));

        listModules = new List<Module>();
        listModules.Add(new Module("Unity 3D", 51));
        listModules.Add(new Module("Suivi Florence", 7));
        listModules.Add(new Module("Certification Unity", 5));
        listModules.Add(new Module("Gamejam", 10));

        objects = new List<PointObject>();
        objects.Add(new PointObject("Object1", new Vector3(0, 5, 10), "enemy"));
        objects.Add(new PointObject("Object2", new Vector3(0, 10, 15), "furniture"));
        objects.Add(new PointObject("Object3", new Vector3(-5, 3, 8), "furniture"));
        objects.Add(new PointObject("Object4", new Vector3(-10, 0, 2), "enemy"));
        objects.Add(new PointObject("Object5", new Vector3(-10, 0, 2), "furniture"));
        objects.Add(new PointObject("Object6", new Vector3(-10, 0, 2), "enemy"));

        listProduct1 = new List<Product>();
        listProduct1.Add(new Product("Ecran MSI", "ecran", 215.99f));
        listProduct1.Add(new Product("Ecran BenQ", "ecran", 198.99f));
        listProduct1.Add(new Product("Corsair Vengeance RGB", "memoire", 250.50f));
        listProduct1.Add(new Product("MSI RTX 2080Ti", "gpu", 1350.99f));
        listProduct1.Add(new Product("Corsair void Elite", "casque", 99.99f));

        listProduct2 = listProduct1.ToList();
        listProduct2.Add(new Product("Intel core i7 10700K", "cpu", 560.99f)); 
        listProduct2.Add(new Product("Thermaltake Water 3.0 360", "watercooling", 225.99f));

        listProduct3 = listProduct2.ToList();
        listProduct3.Add(new Product("Ryzen 9 5950X", "cpu", 459.99f));
        listProduct3.Add(new Product("Corsair HX850", "psu", 225.99f));



    }

    [Test]
    public void _ExList01()
    {
        
        //Given

        var date = DateTime.Now.ToString("dd/MM/yy");
        Debug.Log(date);
        var data = new List<string>() { date, "0830" };

        //When
        var result = Ex01.TellMeThat();

        

        //Then
        Assert.IsTrue(data.SequenceEqual(result));
    }

    [Test]
    public void _ExList02()
    {
        //Given
        var data = listInt.ToList();

        //When
        var result = Ex02.HelpMeToSort(data);

        listInt.Sort();


        //Then
        Assert.IsTrue(listInt.SequenceEqual(result));

    }

    [Test]
    public void _ExList03()
    {
        //Given

        List<Person> data = classroom.ToList();

        //When

        var result = Ex03.WhoIsThatPerson(data);

        var answer = classroom.Find(x => x.FirstName == "Cherif");

        //Then
        Assert.IsTrue(result.Equals(answer));
    }

    [Test]
    public void _ExList04()
    {
        //Given

        var data = classroom;

        //When

        var result = Ex04.ThatEnemy(data);


        //Then
        Assert.IsTrue(result == "Sanglier");

    }

    [Test]
    public void _ExList05()
    {
        //Given

        var data = listModules.ToList();

        //When
        var result = Ex05.CheckModules(data);

        var answer = listModules.FindAll(x => x.Length <= 14 && x.Name.Contains("Unity"));

        //Then
        Assert.IsTrue(answer.SequenceEqual(result));




    }

    [Test]
    public void _ExList06()
    {
        //Given
        PointObject center = new PointObject("center", new Vector3(0, 0, 0),"player");

        var data = objects.ToList();

        //When
        var result = Ex06.AroundTheCenter(center, data);

        var answer = objects.FindAll(x => Vector3.Distance(center.Pos, x.Pos) < 15);

        //Then
        Assert.IsTrue(answer.SequenceEqual(result));


    }

    [Test]
    public void _ExList07()
    {
        //Given
        PointObject center = new PointObject("center", new Vector3(0, 0, 0), "player");

        List<PointObject> data = objects.ToList();

        //When
        var result = Ex07.FilterTheList(data);

        var answer = objects.FindAll(x => x.Tag == "enemy");

        //Then
        Assert.IsTrue(answer.SequenceEqual(result));

    }

    [Test]
    public void _ExList08()
    {
        //Given 
        var result = Ex08.MergeTheLists(listProduct1, listProduct2, listProduct3);

        //When

        var answer = listProduct1.Union(listProduct2).Union(listProduct3).ToList();

        

        //Then

        Assert.IsTrue(answer.SequenceEqual(result));

    }

    [Test]
    public void _ExList09()
    {
        //Given
        var data = classroom.ToList();
        var result = Ex09.SortTheClassRoomList(data);

        //When
        classroom.Sort(delegate (Person x, Person y) {
            return x.FirstName.CompareTo(y.FirstName);
        });

        //Then
        Assert.IsTrue(result.SequenceEqual(classroom));
    }

    [Test]
    public void _ExList10()
    {
        //Given

        //When
        var result = Ex10.CheckTheDuplicate(classroom);

        //Then
        Assert.IsTrue(result.Key.FirstName.Equals(classroom.Find(x => x.FirstName == "Cherif").FirstName) && result.Value == 2);
        
    }

}
