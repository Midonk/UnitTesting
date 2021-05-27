using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex07;

public class QE07
{
    [Test]
    public void LOOK_ROTATION()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.LookRotation(Vector3.down, Vector3.left));

        // When
        var result = mytestSystem.ChangeLookRotation(Quaternion.LookRotation(Vector3.down, Vector3.left));

        // Then
        Assert.AreEqual(result, Quaternion.LookRotation(Vector3.down, Vector3.left));
    }
}