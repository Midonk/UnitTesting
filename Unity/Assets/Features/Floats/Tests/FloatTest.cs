using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Float;


public class FloatTest
{
    [Test]
    public void EX01_TEST_FLOAT()
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
    public void EX02_TEST_FLOAT()
    {
        // Given
        var myTestFloat02 = new Float_ex02(0f);


        // When
        var result = myTestFloat02.CalculateDistance(25f);
        var expected = 25f;


        // Then
        Assert.IsTrue(Mathf.Approximately(expected, result));
    }

    [Test]
    public void EX03_TEST_FLOAT()
    {
        // Given
        var myTestFloat03 = new Float_ex03(30f);

        // When
        var result = myTestFloat03.CalculateSpeed(270f);
        var expected = 9f;

        // Then
        Assert.IsTrue(Mathf.Approximately(expected, result));
    }
    [Test]
    public void EX04_TEST_FLOAT()
    {
        // Given
        var myTestFloat04 = new Float_ex04(1f);

        // When
        var result = myTestFloat04.CalculateStage(17f);
        var expected = 17f;

        // Then
        Assert.IsTrue(Mathf.Approximately(expected, result));
    }

    [Test]
    public void EX05_TEST_FLOAT_EVEN()
    {
        // Given
        var myTestFloat05 = new Float_ex05();

        // When
        var result = myTestFloat05.FindTheNormal(2f);

        // Then
        Assert.IsTrue(result);
    }
    [Test]
    public void EX05_TEST_FLOAT_ODD()
    {
        // Given
        var myTestFloat05 = new Float_ex05();

        // When
        var result = myTestFloat05.FindTheNormal(1f);

        // Then
        Assert.IsFalse(result);
    }
}
