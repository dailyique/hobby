using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    public GameObject RightAnswer;
    public GameObject WrongAnswer;
    public GameObject Question;
    public GameObject MainText;
    public GameObject PlayerHealth;
    public GameObject Canvas;
    public HealthControl HPControl;
    public PlayerControl PControl;

    private void Awake()
    {
        RightAnswer.SetActive(false);
        WrongAnswer.SetActive(false);
        Question.SetActive(false);
        MainText.SetActive(false);
    }

    public void Walk()
    {
        if(MainText.gameObject.activeInHierarchy || Question.gameObject.activeInHierarchy)
        {
            PControl.CanWalk = false;
        }
        else
        {
            PControl.CanWalk = true;
        }
    }

	public void EnterDoor()
    {
        WrongAnswer.SetActive(true);
        RightAnswer.SetActive(true);
        Question.SetActive(true);
        Question.GetComponent<Text>().text = "Q:You can open the door by:";
        WrongAnswer.GetComponentInChildren<Text>().text = "just open it";
        RightAnswer.GetComponentInChildren<Text>().text = "the back of your hand";
    }

    public void Victory()
    {
        float TotalTime;
        TotalTime = Time.time;
        MainText.SetActive(true);
        MainText.GetComponentInChildren<Text>().text = "Congratulations!\nIt took you " + TotalTime + " to escape\nTap to continue";
    }

    public void Erase(GameObject text)
    {
        text.SetActive(false);
    }

    public void WrongAns()
    {
        HPControl.HealthNum -= 5;
        Erase(WrongAnswer);
        Erase(RightAnswer);
        Erase(Question);
        MainText.SetActive(true);
        MainText.GetComponentInChildren<Text>().text = "You are wrong!\nTry again next time!\nTap to continue";
        PlayerHealth.GetComponent<Text>().text = "HP:" + HPControl.HealthNum.ToString();
    }

    public void RightAns()
    {
        Erase(WrongAnswer);
        Erase(RightAnswer);
        Erase(Question);
        MainText.SetActive(true);
        MainText.GetComponentInChildren<Text>().text = "You get the right answer!\nTap to continue";
    }
}
