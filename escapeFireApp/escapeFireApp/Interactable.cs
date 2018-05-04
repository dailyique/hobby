using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public TextControl TControl;
    public PlayerControl PControl;

	void Start () {
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Victory")
        {
            TControl.Victory();
        }
        else if(collision.transform.tag == "Door")
        {
            TControl.EnterDoor();
            Destroy(collision.gameObject);
        }
    }


}
