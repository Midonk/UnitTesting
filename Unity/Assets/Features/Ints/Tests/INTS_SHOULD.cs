using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ints;

using TestIntEx01 = Ints.Int_Ex01;

public class INTS_SHOULD
{
    [Test]
    public void TEST_EX01()
    {
        //given
        var testInt01 = new TestIntEx01();

        //when
        var result = testInt01.CalculateApplesPrices(8);

        //then
        Assert.IsTrue(result == (8 * 3));
    }
}