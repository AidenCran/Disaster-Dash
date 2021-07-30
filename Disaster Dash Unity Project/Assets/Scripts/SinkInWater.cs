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
    public class SinkInWater : MonoBehaviour
    {
        Collider WaterCollider;

        Vector3 topCollider, bottomCollider;

        private void Start()
        {
            WaterCollider = GetComponent<Collider>();

            topCollider = WaterCollider.bounds.max;
            bottomCollider = WaterCollider.bounds.min;

            //Debug.Log("Top Collider Y = " + topCollider.y);
            //Debug.Log("Bottom Collider Y = " + bottomCollider.y);
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                sinkInWaterFunction(other.gameObject);
            }
        }

        public void sinkInWaterFunction(GameObject player)
        {
            if (player.transform.position.y != bottomCollider.y)
            {
                player.transform.position -= new Vector3(0,0.1f,0);
            }
        }
    }
}
