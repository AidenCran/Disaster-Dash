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
    public class SpawnPlatforms : MonoBehaviour
    {
        public Transform StartSpawnLocation;
        [Tooltip("All the prefabs to be spawned as platforms")]
        public GameObject[] PrefabArray;

        public int AmountToSpawn = 10;
        public float MinDistBetweenZ = 5;
        public float MaxDistBetweenZ = 9.5f;

        public float MinDistBetweenX = -3;
        public float MaxDistBetweenX = 3;

        public float clampXRange = 20;
        public float clampZRange = 300;


        private void Start()
        {
            Vector3 clampVector = new Vector3(clampXRange, 0, clampZRange);

            GameObject[] SpawnedObjects = new GameObject[AmountToSpawn];
            Transform newSpawnLocation = StartSpawnLocation;
            Vector3 modifiedSpawnLocation = newSpawnLocation.position;

            for (int i = 0; i < AmountToSpawn; i++)
            {
                SpawnedObjects[i] = Instantiate(PrefabArray[Random.Range(0,PrefabArray.Length)], newSpawnLocation);

                // Detaches Spawned Object from Parent Object
                SpawnedObjects[i].transform.parent = null;

                // Adds some randomness to the spawn
                modifiedSpawnLocation.z = modifiedSpawnLocation.z + Random.Range(MinDistBetweenZ, MaxDistBetweenZ);
                modifiedSpawnLocation.x = modifiedSpawnLocation.x + Random.Range(MinDistBetweenX, MaxDistBetweenX);

                // Clamp Positions
                modifiedSpawnLocation.z = Mathf.Clamp(modifiedSpawnLocation.z, 0, clampZRange);
                modifiedSpawnLocation.x = Mathf.Clamp(modifiedSpawnLocation.x, -clampXRange, clampXRange);

                newSpawnLocation.position = modifiedSpawnLocation;
            }
        }
    }
}
