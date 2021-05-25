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

    [Test]

    public void ShoppingList()
    {
        List<string> list = new List<string>();
        list.Add("pull bleu");
        list.Add("pull rouge");

        var MyBooleanTest = new Boolean_ex02();
        var result = MyBooleanTest.ShoppingList(list);

        Assert.IsFalse(result);
    }
    [Test]
    public void ShoppingList2()
    {
        List<string> list = new List<string>();
        list.Add("pull rouge");
        list.Add("pull gris");

        var MyBooleanTest = new Boolean_ex02();
        var result = MyBooleanTest.ShoppingList(list);

        Assert.IsTrue(result);
    }
}
