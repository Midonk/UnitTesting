using NUnit.Framework;
using Geometries.Runtime;
using UnityEngine;

public class Geometry_ex07_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _smolLala = new Geometry_ex07(0.2f, 0.05f);
        _averageLala = new Geometry_ex07(0.3f, 0.06f);
        _tolLala = new Geometry_ex07(0.4f, 0.07f);
    }

    [Test]
    public void Geometry_ex07_SmolLala()
    {
        var result = _smolLala.LalafelVolume();
        var body = 4.0f * Mathf.PI * Mathf.Pow(_smolLala.m_bodyRadius, 3) / 3;
        var head = 4.0f * Mathf.PI * Mathf.Pow(_smolLala.m_headRadius, 3) / 3;
        var expected = body + head;

        Assert.IsTrue(Mathf.Approximately(result, expected));
    }

    [Test]
    public void Geometry_ex07_AverageLala()
    {
        var result = _averageLala.LalafelVolume();
        var body = 4.0f * Mathf.PI * Mathf.Pow(_averageLala.m_bodyRadius, 3) / 3;
        var head = 4.0f * Mathf.PI * Mathf.Pow(_averageLala.m_headRadius, 3) / 3;
        var expected = body + head;

        Assert.IsTrue(Mathf.Approximately(result, expected));
    }

    [Test]
    public void Geometry_ex07_TolLala()
    {
        var result = _tolLala.LalafelVolume();
        var body = 4.0f * Mathf.PI * Mathf.Pow(_tolLala.m_bodyRadius, 3) / 3;
        var head = 4.0f * Mathf.PI * Mathf.Pow(_tolLala.m_headRadius, 3) / 3;
        var expected = body + head;

        Assert.IsTrue(Mathf.Approximately(result, expected));
    }

    [TearDown]
    public void TearDownTests()
    {
        _smolLala = null;
        _averageLala = null;
        _tolLala = null;
    }

    #endregion
    

    #region Private
    private Geometry_ex07 _smolLala;
    private Geometry_ex07 _averageLala;
    private Geometry_ex07 _tolLala;
    
    #endregion
}
