using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cycle2AidensWork;

namespace Cycle2AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date: 29/04/2021
    /// Last Edited: 29/04/2021 - 1:32 AM
    /// 
    /// 
    /// </summary>
    public class Respawner : MonoBehaviour
    {
        public static Respawner instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        public Transform PlayerObj;
        public Transform RespawnPos;

        public void RespawnFunction()
        {
            PlayerObj.gameObject.GetComponent<FirstPersonMovement>().enabled = false;
            PlayerObj.position = RespawnPos.position;
            PlayerObj.gameObject.GetComponent<FirstPersonMovement>().enabled = enabled;
        }
    }
}
