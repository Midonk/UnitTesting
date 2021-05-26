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
}