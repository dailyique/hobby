using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour {

    public GameObject btnObject;
    public string SceneName;

	// Use this for initialization
	void Start () {
        //GameObject btnObject = GameObject.Find("Item");
        Button btn = btnObject.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            this.Click(btnObject);
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Click(GameObject NScene)
    {
        SceneManager.LoadScene(SceneName);
    }
}
