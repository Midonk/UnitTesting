using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ListSystem;
using NUnit.Framework;
using System.Linq;

public class LIST_SHOULD
{
    List_ex01 listClass = new List_ex01();
    List<Person> classroom;
    List<Module> listModules;
    List<PointObject> objects;
    List<int> listInt;

    [SetUp]
    public void SetUp()
    {

        listInt =  new List<int>() { 5, 8, 1, 3, 4, 26, 15 };

        classroom = new List<Person>();
        classroom.Add(new Person("Cherif", "Younis", "Sanglier"));
        classroom.Add(new Person("Maxime", "Bellens", "Unknown"));
        classroom.Add(new Person("Robin", "Roekens", "Unknown"));
        classroom.Add(new Person("Hervé", "Chiera", "Unknown"));

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

    }

    [Test]
    public void _ExList01()
    {
        //Given
        var data = new List<string>() { "250521", "0830" };

        //When
        var result = listClass.TellMeThat();

        //Then
        Assert.IsTrue(data.SequenceEqual(result));
    }

    [Test]
    public void _ExList02()
    {
        //Given
        var data = listInt.ToList();

        //When
        var result = listClass.HelpMeToSort(data);

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

        var result = listClass.WhoIsThatPerson(data);

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

        var result = listClass.ThatEnemy(data);


        //Then
        Assert.IsTrue(result == "Sanglier");

    }

    [Test]
    public void _ExList05()
    {
        //Given

        var data = listModules.ToList();

        //When
        var result = listClass.CheckModules(data);

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
        var result = listClass.AroundTheCenter(center, data);

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
        var result = listClass.FilterTheList(data);

        var answer = objects.FindAll(x => x.Tag == "enemy");

        //Then
        Assert.IsTrue(answer.SequenceEqual(result));

    }

    [Test]
    public void _ExList08()
    {


    }

    [Test]
    public void _ExList09()
    {


    }

    [Test]
    public void _ExList10()
    {


    }

}
