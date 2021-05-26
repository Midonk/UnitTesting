using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using String_e01 = String_exo01.String_exo01;
public class STRINGS_SHOULD
{
    [Test]
    public void Exo01() 
    {
        var myTryOut = new String_e01();
        var answer1 = myTryOut.TryOut("ping-");
        Assert.IsTrue(answer1 == "ping-pong");
    }
}