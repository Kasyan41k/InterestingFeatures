using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attributes
{
    [RequireComponent(typeof(ColorScript))]
    public class PrintToConsole : MonoBehaviour
    {
        private ColorScript colorScript;
        void Start()
        {
            colorScript = GetComponent<ColorScript>();
            colorScript.myEvent += Print;
        }

        
        void Print()
        {
            Debug.Log(GetComponent<Renderer>().sharedMaterial.color == UnityEngine.Color.red ? "Red" : "Gray");
        }
    }
}

