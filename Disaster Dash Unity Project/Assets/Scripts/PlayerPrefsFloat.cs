using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsFloat : MonoBehaviour
{
    // Declare some variables
    public new string name;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = Math.Round(PlayerPrefs.GetFloat(name), 2) + ""; 
    }
}
