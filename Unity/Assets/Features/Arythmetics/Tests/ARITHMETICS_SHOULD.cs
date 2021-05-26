using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using Ex01 = Arithmetics.Arithmetic_ex01;
using Ex02 = Arithmetics.Arithmetic_ex02;
using Ex03 = Arithmetics.Arithmetic_ex03;
using Ex04 = Arithmetics.Arithmetic_ex04;

public class ARITHMETICS_SHOULD
{
    [Test]
    public void SOLVE01()
    {
        // Given
        var myArithmetics = new Ex01(24f);

        // When
        var result = myArithmetics.CalculateDegrees(Mathf.Sqrt(24.0f)-4f);

        // Then
        Assert.IsTrue(result == Mathf.Sqrt(24.0f)-4f);
    }

    [Test]
    public void SOLVE02()
    {
        // Given
        var myArithmetics = new Ex02((1.2f * 1.2f) + (1.5f * 1.5f));

        // When
        var result = myArithmetics.CalculateHypothesis(Mathf.Sqrt(1.2f * 1.2f + 1.5f * 1.5f));

        // Then
        Assert.IsTrue(result == (Mathf.Sqrt(1.2f * 1.2f + 1.5f * 1.5f)));
    }

    [Test]
    public void SOLVE03()
    {
        // Given
        var myArithmetics = new Ex03(Mathf.Sqrt(1.2f * 1.2f + 1.5f * 1.5f));

        // When
        var result = myArithmetics.CalculateShape(Mathf.Sin(1.2f / Mathf.Sqrt(1.2f * 1.2f + 1.5f * 1.5f)));

        // Then
        Assert.IsTrue(result == (Mathf.Sin(1.2f / Mathf.Sqrt(1.2f * 1.2f + 1.5f * 1.5f))));
    }

    [Test]
    public void SOLVE04()
    {
        // Given
        var myArithmetics = new Ex04(1.5f);

        // When
        var result = myArithmetics.CalculateWaves(Mathf.PingPong(Time.time, 1.5f));

        // Then
        Assert.IsTrue(result == (Mathf.PingPong(2, 1.5f)));
    }
}