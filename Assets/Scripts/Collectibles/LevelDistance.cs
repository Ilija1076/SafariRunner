<<<<<<< HEAD
﻿using System.Collections;
=======
using System.Collections;
>>>>>>> origin/main
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;
    void Update()
    {
<<<<<<< HEAD
        if (addingDis == false)
=======
        if(addingDis == false)
>>>>>>> origin/main
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun++;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        disEndDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
