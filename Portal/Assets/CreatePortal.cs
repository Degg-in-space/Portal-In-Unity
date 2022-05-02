using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePortal : MonoBehaviour
{
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(transform.position, transform.forward, out RaycastHit hitinfo);
            GameObject newPortal = Instantiate(portal, hitinfo.point, Quaternion.Euler(30,60,90));
            Vector3 normal = hitinfo.normal;
            newPortal.transform.LookAt(hitinfo.point + hitinfo.normal);

            Debug.Log(hitinfo.normal);
        }
    }
}
