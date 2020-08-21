using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class BridgeCollison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag ==("Ground")) 
        {
            CameraShaker.Instance.ShakeOnce(10f, 10f, .1f, .1f);
        } 
    }
}
