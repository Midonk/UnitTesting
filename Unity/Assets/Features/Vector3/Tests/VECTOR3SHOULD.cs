using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// Alias
using TestVector3Ex01 = Vector3Tests.Vector3_ex01;
using TestVector3Ex02 = Vector3Tests.Vector3_ex02;
using TestVector3Ex03 = Vector3Tests.Vector3_ex03;
using TestVector3Ex04 = Vector3Tests.Vector3_ex04;
using TestVector3Ex05 = Vector3Tests.Vector3_ex05;
using TestVector3Ex06 = Vector3Tests.Vector3_ex06;
using TestVector3Ex07 = Vector3Tests.Vector3_ex07;
using TestVector3Ex08 = Vector3Tests.Vector3_ex08;
using TestVector3Ex09 = Vector3Tests.Vector3_ex09;
using TestVector3Ex10 = Vector3Tests.Vector3_ex10;


public class VECTOR3SHOULD
{
    [Test]
    public void WhereAmI()
    {
        // Given
        var testVector = new TestVector3Ex01();

        // When
        var result = testVector.WhereAmI(new Vector3(0, 0, 0));

        // Then
        Assert.IsTrue(result == new Vector3(5, 0, 5));
    }

    [Test]
    public void ThisIsNormal()
    {
        // Given
        var testVector = new TestVector3Ex02();

        // When
        var result = testVector.ThisIsNormal(new Vector3(5, 5, 5));

        // Then
        Assert.IsTrue(result == result.normalized);
    }

    [Test]
    public void WorthlessDistance()
    {
        // Given
        var testVector = new TestVector3Ex03();

        // When
        var vect1 = new Vector3(2, 2, 2);
        var vect2 = new Vector3(5, 5, 5);

        var result = testVector.WorthlessDistance(vect1, vect2);

        // Then
        Assert.IsTrue(result == Vector3.Distance(vect1, vect2));
    }

    [Test]
    public void InVelocityITrust()
    {
        // Given
        var testVector = new TestVector3Ex04();

        // When
        var direction = new Vector3(3, 2, 1);
        var speed = 2.5f;

        var result = testVector.InVelocityITrust(direction, speed);

        // Then
        Assert.IsTrue(result == direction * speed);
    }

    [Test]
    public void WalkLikeANinja()
    {
        // Given
        var testVector = new TestVector3Ex05();

        // When
        var position = new Vector3(5, 0, 5);
        var velocity = new Vector3(3, 2, 1) * 2.5f;

        var result = testVector.WalkLikeANinja(position, velocity);

        // Then
        Assert.IsTrue(result == position + velocity);
    }

    [Test]
    public void KeepYourHeadStraight()
    {
        // Given
        var testVector = new TestVector3Ex06();

        // When
        var myPosition = new Vector3(1, 1, 1);
        var mirrorPosition = new Vector3(2, 1, 4);

        var result = testVector.KeepYourHeadStraight(myPosition, mirrorPosition);

        // Then
        Assert.IsTrue(result == (mirrorPosition - myPosition));
    }

    [Test]
    public void DrunkenInterpolationNightmare()
    {
        // Given
        var testVector = new TestVector3Ex07();

        // When
        var headPositionA = new Vector3(1, 0, 2);
        var headPositionB = new Vector3(3, 0, 2);
        var interpolant = 1.0f;

        var result = testVector.DrunkenInterpolationNightmare(headPositionA, headPositionB);

        // Then
        Assert.IsTrue(result == Vector3.Lerp(headPositionA, headPositionB, interpolant));
    }

    [Test]
    public void TheDualityConfusion()
    {
        // Given
        var testVector = new TestVector3Ex08();

        // When
        var playerPosition = new Vector3(1, 0, 1);
        var vision1 = new Vector3(5, 1, 5);
        var vision2 = new Vector3(10, 0, 10);

        var result = testVector.TheDualityConfusion(playerPosition, vision1, vision2);

        var distance1 = Vector3.Distance(playerPosition, vision1);
        var distance2 = Vector3.Distance(playerPosition, vision2);

        Vector3 closestVision;

        if (distance1 < distance2)
        {
            closestVision = vision1;
        }
        else
        {
            closestVision = vision2;
        }

        // Then
        Assert.IsTrue(result == closestVision);
    }

    [Test]
    public void TheCrucialAngle()
    {
        // Given
        var testVector = new TestVector3Ex09();

        // When
        var dogHead1 = new Vector3(3, 0, 5);
        var dogHead2 = new Vector3(6, 0, 5);

        var result = testVector.TheCrucialAngle(dogHead1, dogHead2);
        
        // Then
        Assert.IsTrue(result == Vector3.Angle(dogHead1, dogHead2));
    }

    [Test]
    public void TheMightyVector()
    {
        // Given
        var testVector = new TestVector3Ex10();

        var vector1 = new Vector3(5, 0, 5);
        var vector2 = new Vector3(10, 1, 2);

        // When
        var result = testVector.TheMightyVector(vector1, vector2);
        
        // Then
        Assert.IsTrue(result == Vector3.Max(vector1, vector2));
    }
}