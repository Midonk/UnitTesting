using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex01;

public class QE01 : MonoBehaviour
{
    [Test]
    public void APPLY_ROTATION_FROM_TESTSYSTEM_ON_AXIS_Y_OF_30()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.Euler(0, 30, 0));

        // When
        var result = mytestSystem.ApplyRotationOnY(Quaternion.Euler(0, 30, 0));

        // Then
        Assert.AreEqual(result, Quaternion.Euler(0, 30, 0));
    }
}