using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float depthbeforesubmerged = 1f;
    public float displacementamount = 3f;
    public int floatercount = 1;
    public float waterdrag = 0.99f;
    public float waterangulardrag = 0.5f;

    private void FixedUpdate()
    {
        Rigidbody.AddForceAtPosition(Physics.gravity / floatercount, transform.position, ForceMode.Acceleration);

        float waveheight = WaveManager.instance.getwaveheight(transform.position.x);
        if (transform.position.y < waveheight)
        {
            float displacementmultiplier = Mathf.Clamp01((waveheight - transform.position.y) / depthbeforesubmerged) * displacementamount;
            Rigidbody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y)* displacementmultiplier, 0f),transform.position, ForceMode.Acceleration);
            Rigidbody.AddForce(displacementmultiplier * -Rigidbody.velocity * waterdrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            Rigidbody.AddTorque(displacementmultiplier * -Rigidbody.angularVelocity * waterangulardrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}
