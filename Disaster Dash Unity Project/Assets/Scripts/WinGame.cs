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
    public class WinGame : MonoBehaviour
    {
        public static WinGame instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        public void ResultFunction(string type)
        {
            if (type == "Victory")
            {
                if (PlayerPrefs.GetInt("deathsWin") == 0)
                {
                    PlayerPrefs.SetInt("deathsWin", PlayerPrefs.GetInt("deaths"));
                }

                GameObject PlayerHolder = GameObject.FindGameObjectWithTag("Player");
                PlayerPrefs.SetFloat("achievedDistance", PlayerHolder.transform.position.z + 9); // Player starts at -9
                if (PlayerPrefs.GetFloat("achievedDistance") > PlayerPrefs.GetFloat("bestDistance"))
                {
                    PlayerPrefs.SetFloat("bestDistance", PlayerHolder.transform.position.z + 9); // Player starts at -9
                }

                PlayerPrefs.SetFloat("achievedTime", Time.timeSinceLevelLoad);
                if (PlayerPrefs.GetFloat("achievedTime") < PlayerPrefs.GetFloat("bestTime"))
                {
                    PlayerPrefs.SetFloat("bestTime", PlayerPrefs.GetFloat("achievedTime"));
                }

                PlayerPrefs.SetString("Condition", "Victory");
                ChangeScene.instance.changeSceneFunction("ResultMenu");
            }
            else
            {
                PlayerPrefs.SetInt("deaths", PlayerPrefs.GetInt("deaths") + 1);

                GameObject PlayerHolder = GameObject.FindGameObjectWithTag("Player");
                PlayerPrefs.SetFloat("achievedDistance", PlayerHolder.transform.position.z + 9); // Player starts at -9
                PlayerPrefs.SetFloat("achievedTime", Time.timeSinceLevelLoad);
                if (PlayerPrefs.GetFloat("achievedDistance") > PlayerPrefs.GetFloat("bestDistance"))
                {
                    PlayerPrefs.SetFloat("bestDistance", PlayerHolder.transform.position.z + 9); // Player starts at -9
                    PlayerPrefs.SetFloat("bestTime", PlayerPrefs.GetFloat("achievedTime"));
                }

                PlayerPrefs.SetString("Condition", "Defeat");
                ChangeScene.instance.changeSceneFunction("ResultMenu");
            }
        }
    }
}
