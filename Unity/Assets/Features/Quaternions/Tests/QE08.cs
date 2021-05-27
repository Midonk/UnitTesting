using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex08;

public class QE08
{
    [Test]
    public void GIVE_ROTATION_SOMEWHERE_ELSE()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.Euler(07, 08, 47));

        // When
        var result = mytestSystem.TheTruthIsSomeWhereElse(Quaternion.Euler(07, 08, 47));

        // then
        Assert.AreEqual(result, Quaternion.Euler(07, 08, 47));
    }
}