using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassMold : MonoBehaviour
{
    public GameObject glassbottle;
    public GameObject emptybowl;
    private Vector3 position;
    void OnCollisionEnter(Collision otherObj)
    {
        position = this.transform.position + new Vector3 (0f,1f,0f);

        if (otherObj.gameObject.name.Contains("HotGlassBowl"))
        {
            glassbottle.transform.position = position;
            emptybowl.transform.position = position;
            Destroy(otherObj.gameObject);
            Instantiate(glassbottle);
            Instantiate(glassbottle);
            Instantiate(glassbottle);
            Instantiate(emptybowl);
        }
    }
}
