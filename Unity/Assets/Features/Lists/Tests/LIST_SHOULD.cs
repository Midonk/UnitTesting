using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ListSystem;
using NUnit.Framework;
using System.Linq;

public class LIST_SHOULD
{
    List_ex01 listClass = new List_ex01();

    [Test]
    public void _ExList01()
    {
        //Given
        var data = new List<string>() { "250521", "0830" };

        //When
        var result = listClass.TellMeThat();

        //Then
        Assert.IsTrue(Enumerable.SequenceEqual(data, result));
    }

    [Test]
    public void _ExList02()
    {


    }

    [Test]
    public void _ExList03()
    {


    }

    [Test]
    public void _ExList04()
    {


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
