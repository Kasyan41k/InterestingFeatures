using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

namespace Attributes
{
    public delegate void MyDelegate();
    [ExecuteInEditMode]
    public class ColorScript : MonoBehaviour
    {
        private MyDelegate myDelegate;

        public event MyDelegate myEvent;
        private void Start()
        {
            myDelegate = ChangeToRed;
            StartCoroutine(ChangeColor());
        }
        //Coroutine
        private IEnumerator ChangeColor()
        {
            while (true)
            {
                myDelegate?.Invoke();
                myEvent?.Invoke();

                yield return new WaitForSeconds(1f);
            }
        }

        private void ChangeToRed()
        {
            GetComponent<Renderer>().sharedMaterial.color = UnityEngine.Color.red;
            myDelegate = ChangeToGray;
        }

        private void ChangeToGray()
        {
            GetComponent<Renderer>().sharedMaterial.color = UnityEngine.Color.gray;
            myDelegate = ChangeToRed;
        }
    }
}

