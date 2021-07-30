using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cycle2AidensWork;

namespace Cycle2AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date: 17/4/2021
    /// Last Edited: 17/4/2021
    /// 
    /// When the player falls in the water, they have a couple of seconds to escape
    /// This script will calulate and display that time.
    /// </summary>
    public class displayEscapeTime : MonoBehaviour
    {
        public static displayEscapeTime instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }


        public GameObject TimerObject;
        public TMP_Text remainingTime;

        //bool isTimerActive = false;

        //// Amount of time before the player dies
        //int totalTimeInWater = 3;

        private void Start()
        {
            TimerObject.SetActive(false);
        }

        //public void StartSetactive()
        //{
        //    if (isTimerActive == false)
        //    {
        //        isTimerActive = true;
        //        TimerObject.SetActive(true);
        //        StartCoroutine(SetTimer());
        //    }
        //}

        //public void ResetCoroutine()
        //{
        //    if (isTimerActive == true)
        //    {
        //        isTimerActive = false;
        //        TimerObject.SetActive(false);
        //        StopAllCoroutines();
        //    }
        //}

        //public IEnumerator SetTimer()
        //{
        //    int tempTimeRemaining = totalTimeInWater;

        //    for (int i = 0; i < totalTimeInWater; i++)
        //    {
        //        remainingTime.text = "Timer: " + tempTimeRemaining.ToString();
        //        yield return new WaitForSeconds(.5f);

        //        tempTimeRemaining--;
        //    }

        //    ChangeScene.instance.changeSceneFunction("MainLevel");

        //    isTimerActive = false;
        //    TimerObject.SetActive(false);
        //}
    }
}
