using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {
    public GameObject HP;
    public UIController textCtrl;

    public void StartGame() {
        HP.SetActive(true);
        textCtrl.gameObject.SetActive(true);
        gameObject.SetActive(false);
        //gameObject.GetComponentInChildren<Text>().text=""
    }

}
