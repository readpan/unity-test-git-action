using NUnit.Framework;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Test]
    public void HelloWorld()
    {
        Assert.AreEqual(1, 1);
    }
}