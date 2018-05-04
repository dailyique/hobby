using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildren : MonoBehaviour {

    public Transform[] grandFa;
    public string TagName;

    // Use this for initialization  
    void Start()
    {
        grandFa = GetComponentsInChildren<Transform>();

        foreach (Transform child in grandFa)
        {
            child.tag = TagName;
        }

        // Update is called once per frame  
    }
}