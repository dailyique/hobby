using UnityEngine;

using UnityEngine.EventSystems;

public class LongPressLeft : MonoBehaviour, IPointerUpHandler, IPointerDownHandler

{

    public GameObject run_GameObject;

    public float speed = 10f;

    private bool isMove;
    void Start(){
        
    }

    public void LeftMove()

    {
        run_GameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * -speed;
        //run_GameObject.transform.position += run_GameObject.transform.right * -speed * Time.deltaTime;

    }

    public void Stop()

    {
        run_GameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
       
    }


    // Update is called once per frame

    void Update()
    {

        if (isMove)

        {

           LeftMove();

        }else{
            Stop();
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

