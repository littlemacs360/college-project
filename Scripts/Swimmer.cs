using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimmer : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        RenderSettings.fog = true;
        
    }

    bool IsUnderwater()
        {
            return gameObject.transform.position.y < 0;
        }
    

    // Update is called once per frame
    void Update()
    {
       

        if(IsUnderwater())
        {
            rb.useGravity = false;
            RenderSettings.fogColor = new Color(0.2f, 0.6f, 0.8f, 0.5f);
            RenderSettings.fogDensity = 0.04f;
        }
        else
        {
            rb.useGravity = true;
            RenderSettings.fogColor = new Color(0f, 0.292f, 0.173f, 0.952f);
            RenderSettings.fogDensity = 0.025f;
        }
    }
}
