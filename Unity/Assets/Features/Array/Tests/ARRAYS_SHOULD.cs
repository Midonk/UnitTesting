using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Arrays;

public class ARRAYS_SHOULD
{
    [Test]
    public void RETURN_15_FROM_INT_ARRAY()
    {
        // Given
        var testArray = new int[] { -5, 2, 10, 8, 15, -12 };
        var ArrayEx01 = new Array_ex01(testArray);

        // When
        var result = ArrayEx01.GetHighestStrategicalValuePoint(testArray);

        // Then
        Assert.IsTrue(result == 15);
    }

    [Test]
    public void RETURN_NEGATIVE_5_FROM_NEGATIVE_INT_ARRAY()
    {
        // Given
        var testArray = new int[] { -5, -50, -10, -20, -12, -25 };
        var ArrayEx01 = new Array_ex01(testArray);

        // When
        var result = ArrayEx01.GetHighestStrategicalValuePoint(testArray);

        // Then
        Assert.IsTrue(result == -5);
    }

    [Test]
    public void REPLACE_NULL_IN_ARRAY()
    {
        // Given
        var testArray = new string[] { null, "gear", "stuff", null, "cable", null };
        var ArrayEx02 = new Array_ex02();
        string part = "new part";

        // When 
        ArrayEx02.ReplaceDamagedParts(testArray, part);

        // Then
        Assert.IsTrue(testArray[0] == part && testArray[3] == part && testArray[5] == part);
    }
        
    [Test]
    public void NOT_REPLACE_NOT_NULL_ITEM_IN_ARRAY()
    {
        // Given        
        var testArray = new string[] { null, "gear", "stuff", null, "cable", null };
        var ArrayEx02 = new Array_ex02();
        string part = "new part";

        // When 
        ArrayEx02.ReplaceDamagedParts(testArray, part);

        // Then
        Assert.IsTrue(testArray[1] == "gear" && testArray[2] == "stuff" && testArray[4] == "cable");
    }
}