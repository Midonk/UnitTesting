using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TestVector3Ex01 = Vector3Tests.Vector3_ex01;
using TestVector3Ex02 = Vector3Tests.Vector3_ex02;
using TestVector3Ex03 = Vector3Tests.Vector3_ex03;
using TestVector3Ex04 = Vector3Tests.Vector3_ex04;
using TestVector3Ex05 = Vector3Tests.Vector3_ex05;


public class VECTOR3SHOULD
{
    [Test]
    public void WhereAmI()
    {
        // Given
        var testVector = new TestVector3Ex01();

        // When
        var result = testVector.Check01(new Vector3(0, 0, 0));

        // Then
        Assert.IsTrue(result == new Vector3(5, 0, 5));
    }

    [Test]
    public void Vector3IsNormal()
    {
        // Given
        var testVector = new TestVector3Ex02();

        // When
        var result = testVector.Check02(new Vector3(5, 5, 5));

        // Then
        Assert.IsTrue(result == result.normalized);
    }

    [Test]
    public void Vector3Distance()
    {
        // Given
        var testVector = new TestVector3Ex03();

        // When
        var vect1 = new Vector3(2, 2, 2);
        var vect2 = new Vector3(5, 5, 5);

        var result = testVector.Check03(vect1, vect2);

        // Then
        Assert.IsTrue(result == Vector3.Distance(vect1, vect2));
    }

    [Test]
    public void Vector3Velocity()
    {
        // Given
        var testVector = new TestVector3Ex04();

        // When
        var direction = new Vector3(3, 2, 1);
        var speed = 2.5f;

        var result = testVector.Check04(direction, speed);

        // Then
        Assert.IsTrue(result == direction * speed);
    }

    [Test]
    public void Check05()
    {
        // Given
        var testVector = new TestVector3Ex05();

        // When
        var position = new Vector3(5, 0, 5);
        var velocity = new Vector3(3, 2, 1) * 2.5f;

        var result = testVector.Check05(position, velocity);

        // Then
        Assert.IsTrue(result == position + velocity);
    }
}