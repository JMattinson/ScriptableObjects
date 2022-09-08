using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent,PingEvent,CoinEvent,TimeEvent;

    public float holdTime;
    // Start is called before the first frame update
    private void Awake()
    {
        awakeEvent.Invoke();
        
        startEvent.Invoke();
        if (PingEvent == null) PingEvent = new UnityEvent ();

        PingEvent.AddListener(DisablePing);
        CoinEvent.AddListener(CoinPing);
        
    }



    void OnTriggerEnter(Collider other)
    {
       CoinEvent.Invoke();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        TimeEvent.Invoke();
    }
    void OnDisable()
    {
        disableEvent.Invoke();
        PingEvent.Invoke();
            
        
    }

   


    void DisablePing()
    {
        Debug.Log (gameObject.name+" Disabled! "); 
        
    }

    void CoinPing()
    {
        Debug.Log ("Coin!"); 
    }

   
}
