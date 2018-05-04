using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour {

    public GameObject FireM0;
    public GameObject FireM1;
    public GameObject FireM2;
    private GameObject FireS;
    public GameObject FireStarter;
    private bool Rx;
    float r;

    // Use this for initialization
    void Start () {
        //gameObject.GetComponent<Renderer>().enabled = false;
        r = gameObject.GetComponent<SphereCollider>().radius;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 dir = gameObject.GetComponent<Rigidbody>().velocity;

        if (collision.transform.tag == "Flamable")
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            //Vector3 pos = /*contact.point*/ gameObject.transform.position;
            //FireS = Instantiate(FireM, pos, rot) as GameObject;
            //FireS.transform.LookAt(FireStarter.transform.position);
            //FireS.transform.Rotate(new Vector3(0, 90, 0));
            if(r > 0.05f)
            {
                Rx = true;
                Debug.Log(Rx);
            }
            else if(r < 0.05f)
            {
                Rx = false;
                Debug.Log(Rx);
            }
            SetFire(/*pos*/);
        }
    }
    
    void SetFire(/*Vector3 pos*/)
    {
		float x, y, z;
        int num;
        Vector3 pos = /*contact.point*/ gameObject.transform.position;
        num = Random.Range(0, 3);
        if(num == 0)
        {
            FireS = FireM0;
        }
        else if(num == 1)
        {
            FireS = FireM1;
        }
        else
        {
            FireS = FireM2;
        }
        for (int i = 1; i <=10; i++)
        {
			y = Random.Range (-0.4f, 2.0f);
			x = Random.Range(-0.4f,0.4f);
            z = Random.Range(-1.0f, 1.0f);
            if (r == 0.05f)
            {
                GameObject Target = Instantiate(FireS, new Vector3(pos.x+z, pos.y, pos.z+z), Quaternion.identity) as GameObject;
                Target.transform.Rotate(new Vector3(90, 0, 0));
            }
            else
            {
                
                if (Rx)
                { 
                    GameObject Target = Instantiate(FireS, new Vector3(pos.x, pos.y + y, pos.z+x), Quaternion.identity) as GameObject;
                    if (r == 0.07f)
                    {
                        Target.transform.Rotate(new Vector3(0, 90, 0));
                    }
                    else
                    {
                        Target.transform.Rotate(new Vector3(0, -90, 0));
                    }
                }
                else
                {
					GameObject Target = Instantiate(FireS, new Vector3(pos.x+x, pos.y + y, pos.z), Quaternion.identity) as GameObject;
                    if (r == 0.04f)
                    {
                        Target.transform.Rotate(new Vector3(0, 0, 0));
                    }
                    else
                    {
                        Target.transform.Rotate(new Vector3(180, 0, 0));
                    }
                }
            }
            //if(!Rx)
            //{
            //    Target.transform.Rotate(new Vector3(0, , 0));
            //}
        }
        Destroy(gameObject);
    }

}
