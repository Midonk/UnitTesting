using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ints;

public class INTS_SHOULD
{
    [Test]
    public void TEST_EX01()
    {
        //given
        var testInt01 = new Ints.Int_Ex01();

        //when
        var result = testInt01.CalculateApplesPrices(8);

        //then
        Assert.IsTrue(result == (8 * 3));
    }

    [Test]
    public void TEST_EX02()
    {
        //given
        var testInt02 = new Ints.Int_Ex02();
        var phoneNumber = "000446157643";
        var intPhone = int.Parse(phoneNumber);

        //when
        var result = testInt02.PhoneNumber(phoneNumber);

        //then
        Assert.IsTrue(intPhone == result);
    }

    [Test]
    public void TEST_EX03()
    {
        //given
        var testInt03 = new Ints.Int_Ex03();

        //when
        var result = testInt03.ChangeMoney(3.45f);

        //then
        Assert.IsTrue(3 == result);
    }

    [Test]
    public void TEST_EX04()
    {
        //given
        var testInt04 = new Ints.Int_Ex04();
        var Car = new string[] { "Blue", "Green", "Red", "Yellow", "Black" };

        //when
        var result = testInt04.Parking(Car);

        //then
        Assert.IsTrue(result == 2);
    }

    [Test]
    public void TEST_EX05()
    {
        //given
        var testInt05 = new Ints.Int_Ex05();

        //when
        var result = testInt05.IntMaximum();

        //then
        Assert.IsTrue(result == int.MaxValue);
    }
}