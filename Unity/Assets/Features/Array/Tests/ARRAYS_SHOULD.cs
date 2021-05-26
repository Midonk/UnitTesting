using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Arrays;

public class ARRAYS_SHOULD
{
    [Test]
    public void EX01_RETURN_15_FROM_INT_ARRAY()
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
    public void EX01_RETURN_NEGATIVE_5_FROM_NEGATIVE_INT_ARRAY()
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
    public void EX02_REPLACE_NULL_IN_ARRAY()
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
    public void EX02_NOT_REPLACE_NOT_NULL_ITEM_IN_ARRAY()
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
    public void EX03_HAVE_METAL_AT_INDEX_3_IN_ARRAY()
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
    public void EX03_HAVE_ROCK_AT_INDEX_1_IN_ARRAY()
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
    public void EX03_HAVE_NULL_AT_LAST_INDEX()
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
    public void EX04_RETURN_COORDINATE_2_NEGATIVE_1()
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
    public void EX04_RETURN_COORDINATE_10_5()
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
    public void EX05_RETURN_TRUE()
    {
        // Given
        var activeReactors = new bool[] { true, false, true, true, true, true, false };

        int minimumLoad = 4;
        var ArrayEx05 = new Array_ex05();

        // When
        var result = ArrayEx05.OrbitalCanonCanShoot(activeReactors, minimumLoad);

        // Then
        Assert.IsTrue(result);
    }

    [Test]
    public void EX05_RETURN_FALSE()
    {
        // Given
        var activeReactors = new bool[] { true, true, false, true, true};

        int minimumLoad = 3;
        var ArrayEx05 = new Array_ex05();

        // When
        var result = ArrayEx05.OrbitalCanonCanShoot(activeReactors, minimumLoad);

        // Then
        Assert.IsFalse(result);
    }

    [Test]
    public void EX06_RETURN_4_FROM_REVERSE_ARRAY()
    {   
        // Given
        var array = new int[] { 1, 2, 3, 4, 5 };
        var ArrayEx06 = new Array_ex06();

        // When
        var result = ArrayEx06.RevertArray(array);

        // Then
        Assert.IsTrue(result[1] == 4);
    }

    [Test]
    public void EX06_RETURN_NEGATIVE_3_FROM_REVERSE_ARRAY()
    {
        // Given
        var array = new int[] { 0, 1, 0, -3 };
        var ArrayEx06 = new Array_ex06();   
            
        // When
        var result = ArrayEx06.RevertArray(array);

        // Then
        Assert.IsTrue(result[0] == -3);
    }

    [Test]
    public void EX07_RETURN_5_FROM_ARRAY()
    {
        // Given
        var depositsValueAndDepth = new int[,] { { 2 , 15 }, { 15, 8 }, { 5, 11 }, { 5, 8 }, { 5, 5 } };
        var depthOfMonster = 10;
        var ArrayEx07 = new Array_ex07();

        // When
        var result = ArrayEx07.GetDepositsValues(depositsValueAndDepth, depthOfMonster);

        // Then
        Assert.IsTrue(result[3] == 5);
    }

    [Test]
    public void EX07_RETURN_0_FROM_ARRAY()
    {
        // Given
        var depositsValueAndDepth = new int[,] { { 0, 2 }, { 15, 4 }, { 5, 8 }, { 5, 2 }, { 5, 1 } };
        var depthOfMonster = 5;
        var ArrayEx07 = new Array_ex07();

        // When
        var result = ArrayEx07.GetDepositsValues(depositsValueAndDepth, depthOfMonster);

        // Then
        Assert.IsTrue(result[2] == 0);
    }

    [Test]
    public void EX08_RETURN_37_FROM_ARRAY()
    {
        // Given
        var ArrayEx08 = new Array_ex08();
        var GUN = SoldierType.GUNNER;
        var HEAVY = SoldierType.HEAVYGUNNER;
        var ROCKET = SoldierType.ROCKETLAUNCHER;

        var squads = new SoldierType[,] { { GUN, GUN, GUN, HEAVY, GUN },
                                          { HEAVY, HEAVY, GUN, GUN, HEAVY},
                                          { GUN, ROCKET, HEAVY, GUN, GUN } };

        // When
        var result = ArrayEx08.GetSquadsPower(squads);

        // Then
        Assert.IsTrue(result[2] == 37);
    }

    [Test]
    public void EX08_RETURN_2306_FROM_ARRAY()
    {
        // Given
        var ArrayEx08 = new Array_ex08(101, 251, 1052);
        var GUN = SoldierType.GUNNER;
        var HEAVY = SoldierType.HEAVYGUNNER;
        var ROCKET = SoldierType.ROCKETLAUNCHER;

        var squads = new SoldierType[,] { { GUN, GUN, GUN, HEAVY}, // 554
                                          { GUN, ROCKET, ROCKET, GUN }, // 2306
                                          { HEAVY, HEAVY, GUN, GUN} }; // 704

        // When
        var result = ArrayEx08.GetSquadsPower(squads);

        // Then
        Assert.IsTrue(result[1] == 2306);
    }

    [Test]
    public void EX10_HAVE_METAL_AT_INDEX_1_2_IN_2D_ARRAY()
    {
        // Given        
        var production = new string[] { "tools", "junk", "stone", "box", "weapon", "metal", "trash", "garbage" };
        int capacity = 3;
        var ArrayEx10 = new Array_ex10();

        // When 
        var carrierInventory = ArrayEx10.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsTrue(carrierInventory[1,2] == "metal");
    }

    [Test]
    public void EX10_HAVE_JUNK_AT_INDEX_1_0_IN_2D_ARRAY()
    {
        // Given        
        var production = new string[] { "stone", "weapon", "trash", "rock", "junk", "metal"};
        int capacity = 4;
        var ArrayEx10 = new Array_ex10();

        // When 
        var carrierInventory = ArrayEx10.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsTrue(carrierInventory[1, 0] == "junk");
    }

    [Test]
    public void EX10_HAVE_NULL_AT_INDEX_1_3_IN_2D_ARRAY()
    {
        // Given        
        var production = new string[] { "trash", "junk", "tools", "rock", "junk", "metal" };
        
        int capacity = 5;
        var ArrayEx10 = new Array_ex10();

        // When 
        var carrierInventory = ArrayEx10.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsNull(carrierInventory[1, 3]);
    }

    [Test]
    public void EX10_HAVE_LENGTH_4_ON_FIRST_DIMENSION()
    {
        // Given        
        var production = new string[] { "trash", "junk", "tools", "rock", "junk", "metal", "weapon" };

        int capacity = 2;
        var ArrayEx10 = new Array_ex10();
        
        // When 
        var carrierInventory = ArrayEx10.RessourcesToWarehouses(production, capacity);

        // Then
        Assert.IsTrue(carrierInventory.GetLength(0) == 4);
    }
}

//public enum SoldierType
//{
//    GUNNER = 5,
//    HEAVYGUNNER = 10,
//    ROCKETLAUNCHER = 16
//}