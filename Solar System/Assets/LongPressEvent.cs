using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Script.Event;
using UnityEngine;

public class LongPressEvent : MonoBehaviour
{
    public string FlagId = "un-set";
    public bool MouseDown = false;
    public float DownTime = 0;
    public float LastDown = 0;
    public float LongPressDuration = 1.0f; //in second
    public ParticleSystem ClickEffect = null;
	// Use this for initialization
	void Start ()
	{
	    TriggerPaticleSystem(false);
	}

    // Update is called once per frame
	void Update () {
	    if (MouseDown)
	    {
	        DownTime = Mathf.Max(0, DownTime);
	        DownTime += Time.deltaTime;
	        LastDown = Time.time;
	    }
	    if (Time.time - LastDown >= 1.0f && !MouseDown)
	    {
	        DownTime -= Time.deltaTime;
	    }
	    if (DownTime >= LongPressDuration)
	    {
	        Trigger();
	        MouseDown = false;
	        DownTime = 0;
	    }
        TriggerClickEffect();
	}

    void OnMouseUp()
    {
        Debug.Log("Drag ended!");
//        Trigger();
        MouseDown = false;
    }

    void OnMouseDown()
    {
        MouseDown = true;
        Debug.Log("Down " + FlagId);
    }

    private void Trigger()
    {
        EventStorage.setFlag(FlagId, 1);
    }

    private void TriggerClickEffect()
    {
        TriggerPaticleSystem(MouseDown);
    }

    private void TriggerPaticleSystem(bool Start)
    {
        if (ClickEffect == null)
            return;
        if (Start)
            ClickEffect.Play();
        else 
            ClickEffect.Stop();
    }
}
