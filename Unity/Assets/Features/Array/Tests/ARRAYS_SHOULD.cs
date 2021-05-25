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
        var interestPoints = new int[] { -5, 2, 10, 8, 15, -12 };
        var ArrayEx01 = new Array_ex01(interestPoints);

        // When
        var result = ArrayEx01.GetHighestStrategicalValuePoint(interestPoints);

        // Then
        Assert.IsTrue(result == 15);
    }

    [Test]
    public void RETURN_NEGATIVE_5_FROM_NEGATIVE_INT_ARRAY()
    {
        // Given
        var interestPoints = new int[] { -5, -50, -10, -20, -12, -25 };
        var ArrayEx01 = new Array_ex01(interestPoints);

        // When
        var result = ArrayEx01.GetHighestStrategicalValuePoint(interestPoints);

        // Then
        Assert.IsTrue(result == -5);
    }

    [Test]
    public void REPLACE_NULL_IN_ARRAY()
    {
        // Given
        var techParts = new string[] { null, "gear", "stuff", null, "cable", null };
        var ArrayEx02 = new Array_ex02();
        string newPart = "new part";

        // When
        ArrayEx02.ReplaceDamagedParts(techParts, newPart);

        // Then
        Assert.IsTrue(techParts[0] == newPart && techParts[3] == newPart && techParts[5] == newPart);
    }
        
    [Test]
    public void NOT_REPLACE_NOT_NULL_ITEM_IN_ARRAY()
    {
        // Given        
        var techParts = new string[] { null, "circuits", "button", null, "metal", null };
        var ArrayEx02 = new Array_ex02();
        string newPart = "new part";

        // When
        ArrayEx02.ReplaceDamagedParts(techParts, newPart);

        // Then
        Assert.IsTrue(techParts[1] == "circuits" && techParts[2] == "button" && techParts[4] == "metal");
    }

    [Test]
    public void STOCK_4_METALS_IN_ARRAY()
    {
        // Given        
        var production = new string[] { "metal", "junk", "metal", "rock", "rock", "metal", "metal", "metal" };
        string[] carrierInventory;
        var ArrayEx03 = new Array_ex03(new string[4]);

        // When
        carrierInventory = ArrayEx03.RessourcesForCarrier(production, "metal");

        // Then
        Assert);
    }
}