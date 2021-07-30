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
    public class onTouchWater : MonoBehaviour
    {
        public static onTouchWater instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        bool timerPaused = false;

        // Amount of time before the player dies
        int totalTimeInWater = 6;

        float currentTimeInWater;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player" && timerPaused == false)
            {
                timerPaused = true;

                //displayEscapeTime.instance.StartSetactive();

                StartCoroutine(SetTimer(totalTimeInWater));
            }
            else if (other.gameObject.tag == "Player" && timerPaused == true)
            {
                StopCoroutine(checkIfPlayerReturns());

                StartCoroutine(SetTimer(currentTimeInWater));
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                displayEscapeTime.instance.TimerObject.SetActive(false);
                StopAllCoroutines();
                StartCoroutine(checkIfPlayerReturns());

                Mathf.Clamp(currentTimeInWater, 0, totalTimeInWater);
                currentTimeInWater -= 1;
                Mathf.Clamp(currentTimeInWater, 0, totalTimeInWater);
                //displayEscapeTime.instance.ResetCoroutine();
            }
        }

        IEnumerator checkIfPlayerReturns()
        {
            timerPaused = true;
            yield return new WaitForSeconds(2);
            timerPaused = false;

            //currentTimeInWater = totalTimeInWater;
        }

        public IEnumerator SetTimer(float currentTimeLeft)
        {
            float tempTimeRemaining = currentTimeLeft;
            
            
            displayEscapeTime.instance.TimerObject.SetActive(true);
            
            
            for (int i = 0; i < currentTimeLeft + 1; i++)
            {
                displayEscapeTime.instance.remainingTime.text = "Timer: " + tempTimeRemaining.ToString();
                yield return new WaitForSeconds(.5f);

                currentTimeInWater = tempTimeRemaining;

                tempTimeRemaining--;
            }

            //while (timerPaused)
            //{
            //    yield return null;
            //}

            ChangeScene.instance.changeSceneFunction("MainLevel");

            displayEscapeTime.instance.TimerObject.SetActive(false);
        }

        private void Update()
        {

        }
    }
}
