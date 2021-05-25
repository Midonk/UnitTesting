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
        var data = new List<int>() { 5,8,1,3,4,26,15};
        var listToSort = new List<int>() { 5, 8, 1, 3, 4, 26, 15 };

        //When
        var result = listClass.HelpMeToSort(listToSort);

        data.Sort();


        //Then
        Assert.IsTrue(data.SequenceEqual(result));

    }

    [Test]
    public void _ExList03()
    {
        //Given
        classroom = new List<Person>();
        classroom.Add(new Person("Cherif", "Younis", "Sanglier"));
        classroom.Add(new Person("Maxime", "Bellens", "Unknown"));
        classroom.Add(new Person("Robin", "Roekens", "Unknown"));
        classroom.Add(new Person("Herv�", "Chiera", "Unknown"));

        //When

        var result = listClass.WhoIsThatPerson(classroom);

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


    }

    [Test]
    public void _ExList06()
    {


    }

    [Test]
    public void _ExList07()
    {


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
