using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using Ex01 = Arithmetics.Arithmetic_ex01;

public class ARITHMETICS_SHOULD
{
    [Test]
    public void ARITHMETICS()
    {
        // Given
        var myArithmetics = new Ex01(24f);

        // When
        var result = myArithmetics.CalculateDegrees(Mathf.Sqrt(24.0f)-4f);

        // Then
        Assert.IsTrue(result == Mathf.Sqrt(24.0f)-4f);
    }
}