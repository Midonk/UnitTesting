using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = TestSystem.Quaternion_ex02;

public class QE02 : MonoBehaviour
{
    [Test]
    public void APPLY_INVERSE_ROTATION_FROM_TESTSYSTEM_ON_AXIS_Y_OF_30()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.Inverse(Quaternion.Euler(0, 30, 0)));

        // When
        var result = mytestSystem.ApplyInverseRotationOf30(Quaternion.Inverse(Quaternion.Euler(0, 30, 0)));

        // Then
        Assert.AreEqual(result, Quaternion.Inverse(Quaternion.Euler(0, 30, 0)));
    }
}