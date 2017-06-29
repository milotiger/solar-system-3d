using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform parent = null;
    public Boolean lookat = false;
    public Transform view = null;
	// Use this for initialization
	void Start ()
	{
	    parent = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
	    if (parent != transform.parent)
	    {
	        transform.parent = parent;
	    }
	    if (lookat && parent)
	    {
	        transform.LookAt(parent);
	    }
        ChangeView();
	}

    void ChangeView()
    {
        if (view)
        {
            transform.position = Vector3.Lerp(transform.position, view.position, Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, view.rotation, Time.deltaTime);
        }
    }

    public void SetView(Transform view)
    {
        this.view = view;
    }
}
