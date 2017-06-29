using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private CameraController cameraController;
    public GameObject MainCamera;
    public Transform SunView;
    public Transform EarthView;
    public Transform MoonView;
    public Transform SystemView;
	// Use this for initialization
	void Start ()
	{
	    cameraController = MainCamera.GetComponent<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Q))
	    {
	        cameraController.SetView(SunView);
	    }
        if (Input.GetKey(KeyCode.W))
        {
            cameraController.SetView(EarthView);
        }
        if (Input.GetKey(KeyCode.E))
        {   
            cameraController.SetView(MoonView);
        }
        if (Input.GetKey(KeyCode.R))
        {
            cameraController.SetView(SystemView);
        }
    }
}
