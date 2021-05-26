using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using SystemToTest = TestSystem.Quaternion_ex05;

public class QE05 : MonoBehaviour
{
    [Test]
    public void PRODUCT_BETWEEN_2_INPUTS()
    {
        // Given
        var mytestSystem = new SystemToTest(9998477);

        // When
        var result = mytestSystem.ProductBetween1and2(9998477);

        // Then
        Assert.IsTrue(Mathf.Approximately(result, 9998477));
    }
}