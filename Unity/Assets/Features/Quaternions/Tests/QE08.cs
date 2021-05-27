using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = QuaternionTestSystem.Quaternion_ex08;

public class QE08
{
    [Test]
    public void THE_CRASH_WAS_REAL()
    {
        // Given
        var mytestSystem = new SystemToTest(Quaternion.Euler(08, 07, 47));

        // When
        var result = mytestSystem.TheCrashWasReal(Quaternion.Euler(08, 07, 47));

        // then
        Assert.AreEqual(result, Quaternion.Euler(08, 07, 47));
    }
}