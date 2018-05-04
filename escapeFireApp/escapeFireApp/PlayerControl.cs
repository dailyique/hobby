using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour ,IPointerUpHandler, IPointerDownHandler{

    public bool CanWalk;
    public GameObject MainText;
    public GameObject Player;
    public GameObject WalkButton;
    public TextControl TControl;
    public GameObject MCamera;
    private bool isDown = false;

    void Start()
    {
        CanWalk = true;
    }

    void FixedUpdate()
    {
        TControl.Walk();
        if(isDown)
        {
            if(CanWalk)
            {
                PlayerWalk();
            }
            else
            {
                Debug.Log("1");
                PlayerStop();
            }
        }
        else
        {
            PlayerPause();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }

    public void PlayerWalk()
    {
        Vector3 MoveDirection = MCamera.transform.forward;
        Player.GetComponent<Rigidbody>().velocity = MoveDirection * 2.0f;
    }

    public void PlayerPause()
    {
        Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void PlayerStop()
    {
        //Debug.Log("2");
        //MainText.SetActive(true);
        //MainText.GetComponentInChildren<Text>().text = "Please answer the question first";
    }

}
