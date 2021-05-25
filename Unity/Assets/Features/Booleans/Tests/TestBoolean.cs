using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using BooleanTest;

public class TestBoolean
{
    [Test]
    public void AndShakeTest()
    {
        //given
        var ally = true;
        var enemy = true;
        var MyBooleanTest = new Boolean_ex01();
        //when

        var result = MyBooleanTest.AndShaking(enemy, ally);

        //var 
        //then

        Assert.IsTrue(result);
    }

    [Test]
    public void AndShakeTest2()
    {
        //given
        var ally = true;
        var enemy = false;
        var MyBooleanTest = new Boolean_ex01();
        //when

        var result = MyBooleanTest.AndShaking(enemy, ally);

        //var 
        //then

        Assert.IsFalse(result);
    }
}
