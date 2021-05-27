using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex10;

public class QE10
{
    [Test]
    public void LETS_FLY()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.LookRotation(Vector3.up, Vector3.forward));

        // When
        var result = mytestSystem.LetsFly(Quaternion.LookRotation(Vector3.up, Vector3.forward));

        // Then
        Assert.AreEqual(result, Quaternion.LookRotation(Vector3.up, Vector3.forward));
    }
}