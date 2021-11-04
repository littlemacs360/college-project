using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSand : MonoBehaviour
{

    public GameObject sand;

    private Vector3 position;

    



    void OnCollisionEnter(Collision otherObj)
    {
        position = this.transform.position + new Vector3 (0f,1f,0f);

        if (otherObj.gameObject.name.Contains("EmptySandBowl"))
        {
            Destroy(otherObj.gameObject);
            sand.transform.position = position;
            Instantiate(sand);
        }

    }
}
