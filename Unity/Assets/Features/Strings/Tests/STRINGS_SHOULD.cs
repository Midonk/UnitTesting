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
}