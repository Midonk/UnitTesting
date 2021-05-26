using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = TestSystem.Quaternion_ex01;

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
        //Assert.IsTrue(result == mytestSystem.ApplyRotation(Quaternion.Euler(0, 30, 0)));
    }

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

    [Test]
    public void COME_BACK_FROM_NEGATIVE_30_TO_TESTSYSTEM_ON_AXIS_Y_OF_30()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
                                                                     Quaternion.Euler(0, 30, 0),
                                                                     1));

        // When
        var result = mytestSystem.ComeBackFromNegative30ToRotation30(Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
                                                                                Quaternion.Euler(0, 30, 0),
                                                                                1));

        // Then
        Assert.AreEqual(result, Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
                                                                                Quaternion.Euler(0, 30, 0),
                                                                                1));
    }
}