﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    [Header("UI")]
    public Text score;
    

    [Header("Score")]
    public ScoreManager scoreController;

    // Update is called once per frame
    void Update()
    {
        score.text = scoreController.AmbilDataScore().ToString();
       
    }
}
