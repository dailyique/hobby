﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPersonController : MonoBehaviour {
    public float m_speed = 5f;
    // Use this for initialization
    void Start() {

    }

void MoveControlByTranslate()
{
    if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) //前
    {
        this.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) //后
    {
        this.transform.Translate(Vector3.forward * -m_speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) //左
    {
        this.transform.Translate(Vector3.right * -m_speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) //右
    {
        this.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
    }
}
}
