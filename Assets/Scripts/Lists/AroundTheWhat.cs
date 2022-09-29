using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundTheWhat : MonoBehaviour
{
    private List<string> list = new List<string>() { "Around", "The", "World" };
    void Start()
    {
        foreach (string item in list)
        {
            Debug.Log(item);
        }
    }

}
