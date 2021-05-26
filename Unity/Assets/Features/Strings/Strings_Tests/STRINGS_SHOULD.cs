using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using String_e01 = String_exo01.String_exo01;
using String_e02 = String_exo02.String_exo02;
using String_e03 = String_exo03.String_exo03;
using String_e04 = String_exo04.String_exo04;
using String_e05 = String_exo05.String_exo05;
using String_e06 = String_exo06.String_exo06;
using String_e07 = String_exo07.String_exo07;
using String_e08 = String_exo08.String_exo08;
using String_e09 = String_exo09.String_exo09;
using String_e10 = String_exo10.String_exo10;
public class STRINGS_SHOULD
{
    [Test]
    public void Exo01() 
    {
        var myTryOut = new String_e01();
        var answer1 = myTryOut.TryOut();
        Assert.IsTrue(answer1 == "ping-pong");
    }

    [Test]
    public void Exo02()
    {
        var myTryOut = new String_e02();
        var answer2 = myTryOut.TryOut();
        Assert.IsTrue(answer2 == "PANPANPANPANPANPAN");
    }

    [Test]
    public void Exo03()
    {
        var myTryOut = new String_e03();
        var answer3 = myTryOut.TryOut();
        Assert.IsTrue(answer3 == "Cherif");
    }

    [Test]
    public void Exo04()
    {
        var myTryOut = new String_e04();
        var answer4 = myTryOut.TryOut();
        Assert.IsTrue(answer4 == "Pokemon");
    }

    [Test]
    public void Exo05()
    {
        var myTryOut = new String_e05();
        var answer5 = myTryOut.TryOut();
        Assert.IsTrue(answer5 == 898);
    }

    [Test]
    public void Exo06()
    {
        var myTryOut = new String_e06();
        var answer6 = myTryOut.TryOut();
        Assert.IsTrue(answer6 == 't');
    }

    [Test]
    public void Exo07()
    {
        var myTryOut = new String_e07();
        var answer7 = myTryOut.TryOut();
        Assert.IsTrue(answer7 == "TOUT À FAIT");
    }

    [Test]
    public void Exo08()
    {
        var myTryOut = new String_e08();
        var answer8 = myTryOut.TryOut();
        Assert.IsTrue(answer8 == "");
    }

    [Test]
    public void Exo09()
    {
        var myTryOut = new String_e09();
        var answer9 = myTryOut.TryOut();
        Assert.IsTrue(answer9 == "");
    }

    [Test]
    public void Exo10()
    {
        var myTryOut = new String_e10();
        var answer10 = myTryOut.TryOut();
        Assert.IsTrue(answer10 == "");
    }
}