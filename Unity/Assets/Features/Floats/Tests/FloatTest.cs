using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TestFloat01 = Float.Float_ex01;
using TestFloat02 = Float.Float_ex02;

public class FloatTest
{
    [Test]
    public void TEST_FLOAT_EX01()
    {
        // Given
        var myTestFloat = new TestFloat01(2019f);

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


        // When


        // Then

    }
}
