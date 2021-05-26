using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = TestSystem.Quaternion_ex04;

public class QE04 : MonoBehaviour
{
    [Test]
    public void TURN_THE_CRANE_FROM_LEFT_TO_RIGHT()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.FromToRotation(Vector3.left, Vector3.right));

        // When
        var result = mytestSystem.TurnTheCrane(Quaternion.FromToRotation(Vector3.left, Vector3.right));

        // Then
        Assert.AreEqual(result, Quaternion.FromToRotation(Vector3.left, Vector3.right));
    }
}