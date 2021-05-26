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

        var myBooleanTest = new Boolean_ex02();
        var result = myBooleanTest.ShoppingList(list);

        Assert.IsFalse(result);
    }
    [Test]
    public void ShoppingList2()
    {
        List<string> list = new List<string>();
        list.Add("pull rouge");
        list.Add("pull gris");

        var myBooleanTest = new Boolean_ex02();
        var result = myBooleanTest.ShoppingList(list);

        Assert.IsTrue(result);
    }

    [Test]
    public void SharingBoar()
    {
        var myBooleanTest = new Boolean_ex03();

        var result = myBooleanTest.SharingBoar(5, 25);
        Assert.IsTrue(result);
    }
    [Test]
    public void SharingBoar2()
    {
        var myBooleanTest = new Boolean_ex03();

        var result = myBooleanTest.SharingBoar(25, 4);
        Assert.IsFalse(result);
    }

    [Test]
    public void LyingGame()
    {
        var myBooleanTest = new Boolean_ex04();

        var result = myBooleanTest.LyingGame(true);

        Assert.IsTrue(result);
    }

    [Test]
    public void AvoidingEmpty()
    {

        string[] stringArray = {
            "Ce tableau", "" , "du vide"
        };
        var myBooleanTest = new Boolean_ex05();

        var result = myBooleanTest.AvoidingEmpty(stringArray);

        Assert.IsFalse(result);
    }
    [Test]
    public void AvoidingEmpty2()
    {

        string[] stringArray = {
            "Ce tableau", "posséde pas" , "du vide"
        };
        var myBooleanTest = new Boolean_ex05();

        var result = myBooleanTest.AvoidingEmpty(stringArray);

        Assert.IsTrue(result);
    }
}
