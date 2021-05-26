using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = TestSystem.Quaternion_ex03;

public class QE03 : MonoBehaviour
{
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