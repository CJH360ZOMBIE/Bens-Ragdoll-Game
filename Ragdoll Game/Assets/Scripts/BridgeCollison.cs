using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class BridgeCollison : MonoBehaviour
{
    private bool hasEntered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Shake ()
    {
        CameraShaker.Instance.ShakeOnce(10f, 10f, .1f, .1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag ==("Ground") && !hasEntered) 
        {
            hasEntered = true;
            Shake();
        } 
    }
}
