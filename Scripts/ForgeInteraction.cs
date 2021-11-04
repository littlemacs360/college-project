using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeInteraction : MonoBehaviour
{
    public GameObject hotglass;
    private Vector3 position;
    void OnCollisionEnter(Collision otherObj)
    {
        position = this.transform.position + new Vector3 (0f,1f,0f);

        if (otherObj.gameObject.name.Contains("BowlofSand"))
        {
            hotglass.transform.position = position;
            Destroy(otherObj.gameObject);
            Instantiate(hotglass);
        }
    }
}
