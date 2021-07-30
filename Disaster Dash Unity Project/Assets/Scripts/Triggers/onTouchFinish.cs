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
    public class onTouchFinish : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                WinGame.instance.ResultFunction("Victory");
            }
        }
    }
}
