using System.Collections;
using System.Collections.Generic;
using Assets.Script.Event;
using UnityEngine;

public class ChangeViewManager : MonoBehaviour {
    private CameraController cameraController;
    private Dictionary<string, Transform> ViewMapping = new Dictionary<string, Transform>();
    public GameObject MainCamera;
    public Transform SunView;
    public Transform EarthView;
    public Transform MoonView;
    public Transform SystemView;
    // Use this for initialization
    void Start () {
        cameraController = MainCamera.GetComponent<CameraController>();
        ViewMapping.Add("sun-click", SunView);
        ViewMapping.Add("earth-click", EarthView);
        ViewMapping.Add("moon-click", MoonView);
        ViewMapping.Add("system-click", SystemView);
    }
	
	// Update is called once per frame
	void Update () {
	    foreach (string FlagId in ViewMapping.Keys)
	    {
	        CheckCondition(FlagId, ViewMapping[FlagId]);
	    }
	}

    void CheckCondition(string FlagId, Transform View)
    {
        if (EventStorage.getFlag(FlagId) == 1)
        {
            cameraController.SetView(View);
            EventStorage.setFlag(FlagId, 0);
        }
    }
}
