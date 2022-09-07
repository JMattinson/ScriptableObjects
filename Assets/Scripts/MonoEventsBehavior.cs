using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent,PingEvent;

    private int time;
    // Start is called before the first frame update
    private void Awake()
    {
        awakeEvent.Invoke();
        
    }

    private void Start()
    {
        startEvent.Invoke();
        if (PingEvent == null) PingEvent = new UnityEvent ();

        PingEvent.AddListener(Ping); 
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
        PingEvent.Invoke();
            
        
    }

   
    void Ping()
    {
        Debug.Log (gameObject.name+" Disabled! "); 
        
    } 

   
}
