using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Float;


public class FloatTest
{
    [Test]
    public void TEST_FLOAT_EX01()
    {
        // Given
        var myTestFloat = new Float_ex01(2019f);

        // When
        var years = myTestFloat.CalculateYears(15f);
        var expected = 2034f;

        // Then
        Assert.IsTrue(Mathf.Approximately(expected, years));
    }

    [Test]
    public void TEST_FLOAT_EX02()
    {
        // Given
        var myTestFloat02 = new Float_ex02(0f);


        // When
        var result = myTestFloat02.CalculateDistance(25f);
        var expected = 25f;


        // Then
        Assert.IsTrue(Mathf.Approximately(expected, result));

    }
}
