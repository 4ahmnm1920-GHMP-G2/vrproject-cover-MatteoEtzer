using UnityEngine;
using Valve.VR;
using System.Collections;
using System.Collections.Generic;

public class weapon : MonoBehaviour
{
    //public SteamVR_TrackedObject mTrackedObject = null;

    public Camera fpsCam;
    public float damage = 10f;
    public float range = 100f;

    void Update()
    {
       
        if (Input.GetButton("space"))
        {
            Shoot();
        }    
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
