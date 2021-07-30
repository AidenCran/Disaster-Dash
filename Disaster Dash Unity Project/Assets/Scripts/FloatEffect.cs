using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cycle2AidensWork;

namespace Cycle2AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date:
    /// Last Edited:
    /// 
    /// 
    /// </summary>
    public class FloatEffect : MonoBehaviour
    {
        private void Start()
        {
            Xmagnitude = Random.Range(XminMagnitude, XmaxMagnitude);
            Xfrequency = Random.Range(XminFrequency, XmaxFrequency);

            Ymagnitude = Random.Range(YminMagnitude, YmaxMagnitude);
            Yfrequency = Random.Range(YminFrequency, YmaxFrequency);

            Zmagnitude = Random.Range(ZminMagnitude, ZmaxMagnitude);
            Zfrequency = Random.Range(ZminFrequency, ZmaxFrequency);
        }

        public void Update()
        {
            //rotateX();
            //rotateY();
            //rotateZ();
        }

        float Xfrequency = 1;
        float XminFrequency = 0.5f;
        float XmaxFrequency = 1.5f;

        float Xmagnitude = 50;
        float XminMagnitude = 20;
        float XmaxMagnitude = 40;

        void rotateX()
        {
            transform.rotation = Quaternion.Euler(Vector3.right * Mathf.Sin(Time.time * Xfrequency) * Xmagnitude);
        }

        float Yfrequency = 1;
        float YminFrequency = 0.5f;
        float YmaxFrequency = 1.5f;

        float Ymagnitude = 50;
        float YminMagnitude = 20;
        float YmaxMagnitude = 40;

        void rotateY()
        {
            transform.rotation = Quaternion.Euler(Vector3.up * Mathf.Sin(Time.time * Yfrequency) * Ymagnitude);
        }

        float Zfrequency = 1;
        float ZminFrequency = 0.5f;
        float ZmaxFrequency = 1.5f;

        float Zmagnitude = 50;
        float ZminMagnitude = 20;
        float ZmaxMagnitude = 40;
        void rotateZ()
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * Mathf.Sin(Time.time * Zfrequency) * Zmagnitude);
        }



    }
}
