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
    public void TEST_EX03_VARIANT()
    {
        //given
        var testInt03 = new Ints.Int_Ex03();

        //when
        var result = testInt03.ChangeMoney(4.12f);

        //then
        Assert.IsTrue(4 == result);
    }

    [Test]
    public void TEST_EX04()
    {
        //given
        var testInt04 = new Ints.Int_Ex04();
        var car = new string[] { "Blue", "Green", "Red", "Yellow", "Black" };

        //when
        var result = testInt04.Parking(car);

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

    [Test]
    public void TEST_EX06()
    {
        //given
        var testInt06 = new Ints.Int_Ex06();
        var catYearOld = new int[] { 4, 7, 9, 1, 3 };
        var dogYearOld = new int[] { 5, 8, 7, 5, 10 };

        //when
        var result = testInt06.PetsYearOld(catYearOld, dogYearOld);

        //then
        Assert.IsTrue(result == 1);
    }

    [Test]
    public void TEST_EX07()
    {
        //given
        var testInt07 = new Ints.Int_Ex07();

        //when
        var result = testInt07.PaulTheHandyman(5.50f, 5.20f);

        //then
        Assert.IsTrue(Mathf.Approximately(result, (6 * 5.20f)));
    }
}