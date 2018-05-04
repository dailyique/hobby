﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class ExitScene : MonoBehaviour {
    public Text Show;
    float fadingSpeed = 1;
    bool fading;
    float startFadingTimep;
    Color originalColor;
    Color transparentColor;
 
    void Start () {
        originalColor = Show.color;
        transparentColor = originalColor;
        transparentColor.a = 0;
		Show.text = "DOUBLE TAP to RETURN\nto the Menu Scene";
        Show.color = transparentColor;
    }   
 
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (startFadingTimep==0)
            {
                Show.color = originalColor;
                startFadingTimep = Time.time;
                fading = true;
            }
            else
            {
                Debug.Log("hhh");
                //Application.Quit();
				SceneManager.LoadScene(0);
            }
        }
        if (fading)
        {
            Show.color = Color.Lerp(originalColor, transparentColor, (Time.time - startFadingTimep) * fadingSpeed);
            if (Show.color.a<2.0/255)
            {
                Show.color = transparentColor;
                startFadingTimep = 0;
                fading = false;
            }
        }
    }
}