using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex06;

public class QE06
{
    [Test]
    public void INTERPOLATE_BETWEEN_2_QUATERNION()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.Slerp(Quaternion.Euler(13, 3, 21), Quaternion.Euler(27, 5, 21), 1));

        // When
        var result = mytestSystem.GetTheSlerp(Quaternion.Slerp(Quaternion.Euler(13, 3, 21), Quaternion.Euler(27, 5, 21), 1));

        // Then
        Assert.AreEqual(result, Quaternion.Slerp(Quaternion.Euler(13, 3, 21), Quaternion.Euler(27, 5, 21), 1));
    }
}