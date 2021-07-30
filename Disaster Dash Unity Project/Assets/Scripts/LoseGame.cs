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
    public class LoseGame : MonoBehaviour
    {
        public static LoseGame instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        public void LoseGameFunction()
        {
            //Respawner.instance.RespawnFunction();

            ChangeScene.instance.changeSceneFunction("ResultMenu");
        }
    }
}
