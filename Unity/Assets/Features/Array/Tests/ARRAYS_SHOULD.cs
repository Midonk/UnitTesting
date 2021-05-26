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
        var ArrayEx01 = new Array_ex01();

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
        var ArrayEx01 = new Array_ex01();

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
    public void HAVE_METAL_AT_INDEX_3_IN_ARRAY()
    {
        // Given        
        var production = new string[] { "metal", "junk", "metal", "rock", "rock", "metal", "metal", "metal" };
        string[] carrierInventory;
        var ArrayEx03 = new Array_ex03(new string[4]);

        // When
        carrierInventory = ArrayEx03.RessourcesForCarrier(production, "metal");

        // Then
        Assert.IsTrue(carrierInventory[3] == "metal");
    }

    [Test]
    public void HAVE_ROCK_AT_INDEX_1_IN_ARRAY()
    {
        // Given            
        var production = new string[] { "metal", "junk", "metal", "rock", "rock", "metal", "metal", "rock" };
        string[] carrierInventory;
        var ArrayEx03 = new Array_ex03(new string[3]);

        // When
        carrierInventory = ArrayEx03.RessourcesForCarrier(production, "rock");

        // Then
        Assert.IsTrue(carrierInventory[1] == "rock");
    }

    [Test]
    public void HAVE_NULL_AT_LAST_INDEX()
    {
        // Given        
        var production = new string[] { "metal", "junk", "metal", "rock", "rock", "metal", "metal", "rock" };
        string[] carrierInventory;
        var ArrayEx03 = new Array_ex03(new string[4]);

        // When
        carrierInventory = ArrayEx03.RessourcesForCarrier(production, "junk");

        // Then
        Assert.IsNull(carrierInventory[3]);
    }

    [Test]
    public void RETURN_COORDINATE_2_NEGATIVE_1()
    {
        // Given        
        var enemyCoordonates = new Vector2[] { new Vector2(2, -1),
                                               new Vector2(3, 1),
                                               new Vector2(-1, 5),
                                               new Vector2(0, 6) };

        var radarPosition = new Vector2(0, 0);
        var ArrayEx04 = new Array_ex04();

        // When
        var result = ArrayEx04.GetClosestEnemyPosition(radarPosition, enemyCoordonates);

        // Then
        Assert.IsTrue(result == new Vector2(2, -1));
    }

    [Test]
    public void RETURN_COORDINATE_10_5()
    {
        // Given        
        var enemyCoordonates = new Vector2[] { new Vector2(0, -1),
                                               new Vector2(1, 8),
                                               new Vector2(10, 5),
                                               new Vector2(2, -2) };

        var radarPosition = new Vector2(9, 5);
        var ArrayEx04 = new Array_ex04();

        // When
        var result = ArrayEx04.GetClosestEnemyPosition(radarPosition, enemyCoordonates);

        // Then
        Assert.IsTrue(result == new Vector2(10, 5));
    }

    [Test]
    public void RETURN_TRUE()
    {
        // Given        
        var activatedReactors = new bool[] { true, false, true, true, true, true, false };

        int minimumLoad = 4;
        var ArrayEx05 = new Array_ex05();

        // When
        var result = ArrayEx05.OrbitalCanonCanShoot(activatedReactors, minimumLoad);

        // Then
        Assert.IsTrue(result);
    }

    [Test]
    public void RETURN_FALSE()
    {
        // Given        
        var activatedReactors = new bool[] { true, true, false, true, true};

        int minimumLoad = 3;
        var ArrayEx05 = new Array_ex05();

        // When
        var result = ArrayEx05.OrbitalCanonCanShoot(activatedReactors, minimumLoad);

        // Then
        Assert.IsFalse(result);
    }

    [Test]
    public void HAVE_METAL_AT_INDEX_1_2_IN_2D_ARRAY()
    {
        // Given        
        var production = new string[] { "tools", "junk", "stone", "box", "weapon", "metal", "trash", "garbage" };
        int capacity = 3;
        var ArrayEx04 = new Array_ex10();

        // When 
        var carrierInventory = ArrayEx04.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsTrue(carrierInventory[1,2] == "metal");
    }

    [Test]
    public void HAVE_JUNK_AT_INDEX_1_0_IN_2D_ARRAY()
    {
        // Given        
        var production = new string[] { "stone", "weapon", "trash", "rock", "junk", "metal"};
        int capacity = 4;
        var ArrayEx04 = new Array_ex10();

        // When 
        var carrierInventory = ArrayEx04.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsTrue(carrierInventory[1, 0] == "junk");
    }

    [Test]
    public void HAVE_NULL_AT_INDEX_1_3_IN_2D_ARRAY()
    {
        // Given        
        var production = new string[] { "trash", "junk", "tools", "rock", "junk", "metal" };
        
        int capacity = 5;
        var ArrayEx04 = new Array_ex10();

        // When 
        var carrierInventory = ArrayEx04.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsNull(carrierInventory[1, 3]);
    }
}