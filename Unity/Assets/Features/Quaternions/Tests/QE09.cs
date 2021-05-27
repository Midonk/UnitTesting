using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex09;

public class QE09
{
    [Test]
    public void INDEPENDANCE_DAY()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.Euler(04, 07, 76));

        // When
        var result = mytestSystem.IndependanceDay(Quaternion.Euler(04, 07, 76));

        // then
        Assert.AreEqual(result, Quaternion.Euler(04, 07, 76));
    }
}