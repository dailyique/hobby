using UnityEngine;

using UnityEngine.EventSystems;

public class LongPressRight : MonoBehaviour, IPointerUpHandler, IPointerDownHandler

{

    public GameObject run_GameObject;

    public float speed = 10f;

    private bool isMove;

    public void RightMove()

    {
        run_GameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
        //run_GameObject.transform.position += run_GameObject.transform.right * speed * Time.deltaTime;

    }


    // Update is called once per frame

    void Update()
    {

        if (isMove)

        {

           RightMove();

        }


    }


    public void OnPointerUp(PointerEventData eventData)

    {

        isMove = false;

    }

    public void OnPointerDown(PointerEventData eventData)

    {

        isMove = true;

    }

}

