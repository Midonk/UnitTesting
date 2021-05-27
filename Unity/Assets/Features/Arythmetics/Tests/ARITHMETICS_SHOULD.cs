using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using Ex01 = Arithmetics.Arithmetic_ex01;
using Ex02 = Arithmetics.Arithmetic_ex02;
using Ex03 = Arithmetics.Arithmetic_ex03;
using Ex04 = Arithmetics.Arithmetic_ex04;
using Ex05 = Arithmetics.Arithmetic_ex05;
using Ex06 = Arithmetics.Arithmetic_ex06;
using Ex07 = Arithmetics.Arithmetic_ex07;
using Ex08 = Arithmetics.Arithmetic_ex08;
using Ex09 = Arithmetics.Arithmetic_ex09;
using Ex10 = Arithmetics.Arithmetic_ex10;

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

    [Test]
    public void SOLVE05()
    {
        // Given
        var myArithmetics = new Ex05(10.0f);

        // When
        var result = myArithmetics.CalculateWavesWidth(Mathf.Lerp(1.5f, 10f, Time.time));

        // Then
        Assert.IsTrue(result == Mathf.Lerp(1.5f, 10f, Time.time));
    }

    [Test]
    public void SOLVE06()
    {
        // Given
        var myArithmetics = new Ex06(4.8f);

        // When
        var result = myArithmetics.CalculateBeachLength(4.8f);

        // Then
        Assert.IsTrue(result == Mathf.Round(4.8f));
    }

    [Test]
    public void SOLVE07()
    {
        // Given
        var myArithmetics = new Ex07();

        // When
        var result = myArithmetics.CalculateTime(Mathf.Round(4.8f), 3.0f);

        // Then
        Assert.IsTrue(Mathf.Approximately(result, Mathf.Round(4.8f) / 3.0f));
    }

    [Test]
    public void SOLVE08()
    {
        // Given
        var myArithmetics = new Ex08();

        // When
        var result = myArithmetics.CalculatePositiveTime(Mathf.Round(-4.8f), 3.0f);

        // Then
        Assert.IsTrue(Mathf.Approximately(result, (Mathf.Abs(Mathf.Round(-4.8f) * 2) / 3.0f)));
    }

    [Test]
    public void SOLVE09()
    {
        // Given
        var myArithmetics = new Ex09();

        // When
        var result = myArithmetics.CalculateTimeToRoom(2.2f, 3.0f);

        // Then
        Assert.IsTrue(result == Mathf.Pow(3.0f, 2.2f));
    }

    [Test]
    public void SOLVE10()
    {
        // Given
        var myArithmetics = new Ex10();

        // When
        var result = myArithmetics.Calculate(6);

        // Then
        var expected = 1;
        for (int i = 1; i <= 6; i++)
        {
            expected *= i;
        }

        Assert.IsTrue(result == expected);
    }
}