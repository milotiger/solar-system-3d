using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public float RotateSpeed = 0.05f;
    public float PingPongSpeed = 0.5f;
    public float PingPongLength = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Rotate();
        PingPong();
	}

    void Rotate()
    {
       transform.Rotate(new Vector3( RotateSpeed * Time.deltaTime, 0, 0));
    }

    void PingPong()
    {
        transform.position = new Vector3(Mathf.Sin(Mathf.PingPong(Time.time * PingPongSpeed, Mathf.PI)) * PingPongLength, transform.position.y, transform.position.z);
    }
}
