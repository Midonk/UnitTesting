using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TestVector3Ex01 = Vector3Tests.Vector3_ex01;
using TestVector3Ex02 = Vector3Tests.Vector3_ex02;

public class VECTOR3SHOULD
{
    [Test]
    public void Vector3Values()
    {
        // Given
        var testVector = new TestVector3Ex01();
        
        // When
        var result = testVector.Check01(new Vector3(0,0,0));
        
        // Then
        Assert.IsTrue(result == new Vector3(5, 0, 5));
    }
    
    [Test]
    public void Vector3IsNormal()
    {
        // Given
        var testVector = new TestVector3Ex02();
        
        // When
        var result = testVector.Check02(new Vector3(5,5,5));
        
        // Then
        Assert.IsTrue(result == result.normalized);
    }
}