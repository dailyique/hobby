using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow1 : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (target.transform.position.x, target.transform.position.y + 1.35f, target.transform.position.z);
		this.transform.eulerAngles = target.transform.eulerAngles;
	}
}
