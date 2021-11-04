using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortarandpestle : MonoBehaviour
{
    public GameObject Redpowder;
    public GameObject Yellowpowder;
    public GameObject GreenPowder;
    public GameObject BluePowder;
    private Vector3 position;


    void OnCollisionEnter(Collision otherObj)
    {
        position = this.transform.position + new Vector3 (0f,1f,0f);

        if (otherObj.gameObject.name.Contains("Redcap"))
        {
            Redpowder.transform.position = position;
            Destroy(otherObj.gameObject);
            Instantiate(Redpowder);
        }

        if (otherObj.gameObject.name.Contains("Browncap"))
        {
            Yellowpowder.transform.position = position;
            Destroy(otherObj.gameObject);
            Instantiate(Yellowpowder);
        }

        if (otherObj.gameObject.name.Contains("ToxicShroom"))
        {
            GreenPowder.transform.position = position;
            Destroy(otherObj.gameObject);
            Instantiate(GreenPowder);
            Instantiate(GreenPowder);
            Instantiate(GreenPowder);
        }

        if (otherObj.gameObject.name.Contains("MagicShrooms"))
        {
            BluePowder.transform.position = position;
            Destroy(otherObj.gameObject);
            Instantiate(BluePowder);
            Instantiate(BluePowder);
            Instantiate(BluePowder);
        }



    }
}
