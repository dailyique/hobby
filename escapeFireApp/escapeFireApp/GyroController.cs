using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.gyro.enabled)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, ConvRotation(Input.gyro.attitude), 0.5f);
        }
	}

    private Quaternion ConvRotation(Quaternion q)
    {
        return Quaternion.Euler(90, 0, 0) * (new Quaternion(-q.x, -q.y, q.z, q.w));
    }
}
