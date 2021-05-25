using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Arrays;

public class ARRAYS_SHOULD
{
    //[Test]
    //public void TEST_TEMPLATE()
    //{
    //    // Given


    //    // When


    //    // Then

    //}

    [Test]
    public void RETURN_15_FROM_INT_ARRAY()
    {
        // Given
        var testArray = new int[] { -5, 2, 10, 8, 15, -12 };
        var ArrayEx01 = new Array_ex01(testArray);

        // When
        var result = ArrayEx01.GetHighestStrategicalValuePoint(testArray);

        // Then
        Assert.IsTrue(Mathf.Approximately(result, 15));
    }

    [Test]
    public void RETURN_NEGATIVE_5_FROM_INT_ARRAY()
    {
        // Given
        var testArray = new int[] { -5, -50, -10, -20, -12, -25 };
        var ArrayEx01 = new Array_ex01(testArray);

        // When
        var result = ArrayEx01.GetHighestStrategicalValuePoint(testArray);

        // Then
        Assert.IsTrue(Mathf.Approximately(result, -5));
    }
}
