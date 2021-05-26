using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using String_e01 = String_exo01.String_exo01;
using String_e02 = String_exo02.String_exo02;
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
    public void Exo2()
    {
        var myTryOut = new String_e02();
        var answer2 = myTryOut.TryOut();
        Assert.IsTrue(answer2 == "PANPANPANPANPANPAN");
    }
}