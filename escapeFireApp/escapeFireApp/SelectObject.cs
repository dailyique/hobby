using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectObject : MonoBehaviour
{
    void Update()
    {
        SelectObj();
    }
    public void SelectObj()
    {
        //Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2,Screen.height/2,0));
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            Debug.DrawLine(ray.origin, hitInfo.point);
            GameObject gameObj = hitInfo.collider.gameObject;
            //Debug.Log("click object name is " + gameObj.name);
            if (gameObj.tag == "Player")
            {
                Debug.Log("pickup!");
                gameObj.SetActive(false);
                //Application.LoadLevel("menu");  // sceneName就是你要加载的场景----这是老式的用法
                SceneManager.LoadScene(1);//1是场景的索引
                                                      // Application.LoadLevel(sceneName);
            }
            else if(gameObj.tag == "player2")
            {
                Debug.Log("pickup!");
                gameObj.SetActive(false);
                //Application.LoadLevel("menu");  // sceneName就是你要加载的场景----这是老式的用法
                SceneManager.LoadScene(2);//1是场景的索引
                                                      // Application.LoadLevel(sceneName);
            }
        }
    }
}
