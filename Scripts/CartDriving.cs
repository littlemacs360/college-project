using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartDriving : MonoBehaviour
{
    public GameObject Wheels;
    public GameObject PlayerTransform;
    public Transform carroot;

    void OnTriggerEnter(Collider otherobj)
    {
        if(otherobj.name == "Player")
        {
            PlayerTransform.gameObject.GetComponent<Bolt.FlowMachine>().enabled = false;
            PlayerTransform.gameObject.GetComponent<Rigidbody>().useGravity = false;
            otherobj.gameObject.transform.parent = this.gameObject.transform;
            PlayerTransform.transform.position = this.gameObject.transform.position;
            PlayerTransform.transform.rotation = new Quaternion (0f,0f,0f,0f);

            Wheels.GetComponent<WheelDrive>().maxAngle = 30;
            Wheels.GetComponent<WheelDrive>().maxTorque = 15;
        }
    }

    void Update()
    {
        if(PlayerTransform.transform.parent.name == "CartDriver")
        {
            PlayerTransform.transform.rotation = carroot.transform.rotation;
            PlayerTransform.transform.position = this.gameObject.transform.position + new Vector3 (0f,0.55f,0f);
        }

        if(Input.GetKeyUp("q") && PlayerTransform.transform.parent.name == "CartDriver")
        {
            PlayerTransform.transform.localPosition = PlayerTransform.transform.localPosition + new Vector3(0f,0f,2f);
            PlayerTransform.transform.parent = null;
            PlayerTransform.gameObject.GetComponent<Rigidbody>().useGravity = true;
            PlayerTransform.gameObject.GetComponent<Bolt.FlowMachine>().enabled = true;

            Wheels.GetComponent<WheelDrive>().maxAngle = 0;
            Wheels.GetComponent<WheelDrive>().maxTorque = 0;            
        }
        
    }
        
    
}
