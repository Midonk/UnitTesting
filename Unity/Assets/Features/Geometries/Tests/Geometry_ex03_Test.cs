using System;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Geometries.Runtime;

public class Geometry_ex03_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _ChocoboForestToCave = new Geometry_ex03(new Vector2Int(3, 5), new Vector2Int(10, 8));
        _MoblitzToVeldt = new Geometry_ex03(new Vector2Int(-10, 3), new Vector2Int(0, -5));
        _NarsheToFigaro = new Geometry_ex03(new Vector2Int(5, 0), new Vector2Int(-7, 4));
    }

    [Test]
    public void Geometry_ex03_TestChocoboForestToCave()
    {
        var result = _ChocoboForestToCave.ComputeDistance();
        var expectation = Mathf.Sqrt(Mathf.Pow(10-3, 2) + Mathf.Pow(8-5, 2));

        Assert.IsTrue(Mathf.Approximately(result, expectation), "Terra c'est perdue dans la matrice.");
    }

    [Test]
    public void Geometry_ex03_TestMoblitzToVeldt()
    {
        var result = _MoblitzToVeldt.ComputeDistance();
        var expectation = Mathf.Sqrt(Mathf.Pow(0+10, 2) + Mathf.Pow(-5-3, 2));

        Assert.IsTrue(Mathf.Approximately(result, expectation), "Terra c'est perdue dans la matrice.");
    }

    [Test]
    public void Geometry_ex03_TestNarsheToFigaro()
    {
        var result = _NarsheToFigaro.ComputeDistance();
        var expectation = Mathf.Sqrt(Mathf.Pow(-7-5, 2) + Mathf.Pow(4-0, 2));

        Assert.IsTrue(Mathf.Approximately(result, expectation), "Terra c'est perdue dans la matrice.");
    }

    [TearDown]
    public void TearDownTests()
    {
        _ChocoboForestToCave = null;
        _MoblitzToVeldt = null;
        _NarsheToFigaro = null;
    }

    #endregion
    

    #region Private
    private Geometry_ex03 _NarsheToFigaro;
    private Geometry_ex03 _MoblitzToVeldt;
    private Geometry_ex03 _ChocoboForestToCave;
    
    #endregion
}
