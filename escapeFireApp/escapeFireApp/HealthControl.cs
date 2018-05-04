using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthControl : MonoBehaviour {

    private float CurrentTime;
    private float LastTime;
    public int HealthNum;
    public int dieSpeed = 2;
    public GameObject MainText;
    
	// Use this for initialization
	void Start () {
        CurrentTime = 0;
        LastTime = 0;
        HealthNum = 100;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        CurrentTime = Time.time;
        if(CurrentTime - LastTime >= 1.0f)
        {
            HealthNum -= dieSpeed;
            if (HealthNum < 1) {
                MainText.SetActive(true);
                MainText.GetComponent<Text>().text = "Ooooooooops!\n\nYou Lose!\n\nMore Attention Next Time!";
                gameObject.GetComponent<Text>().text = "";
            }
            else {
                gameObject.GetComponent<Text>().text = "HP:" + HealthNum.ToString();
                LastTime = CurrentTime;
            }
            
        }
	}
}
