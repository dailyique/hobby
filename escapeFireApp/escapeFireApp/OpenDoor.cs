using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour {
	public bool isUIOn = false;
    public GameObject winPS;
    public GameObject hp;
    private void Start()
    {
        winPS.SetActive(false);
    }
    private void FixedUpdate()
    {
        Physics.gravity = new Vector3(0, -95, 0);  // gravity= -35 其他的默认
    }
    void OnCollisionEnter(Collision other){
        
        if (other.gameObject.tag == "Door") {
            //Debug.Log("111");
			isUIOn = true;
			other.gameObject.SetActive (false);
		}
        if (other.gameObject.tag == "Ground") {
            winPS.SetActive(true);
            winPS.GetComponent<Text>().text = "Yeeeeeeah!\nYou Win!";
            gameObject.GetComponent<Text>().text = "";
            hp.SetActive(false);
        }

        if (other.gameObject.tag == "ExitDoor") {
            other.gameObject.SetActive(false);
            hp.SetActive(false);
        }
	}
}
