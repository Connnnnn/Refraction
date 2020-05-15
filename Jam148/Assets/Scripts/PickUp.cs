using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;
    public bool carry;
    //float rotSpeed = 100;
    
    void OnMouseDown()
    {
        carry = true;
        //GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
       // GetComponent <Rigidbody>().isKinematic = true;
        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("Destination").transform;

    }

     void OnMouseUp()
    {
        carry = false;
        
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
        //GetComponent<Rigidbody>().isKinematic = false;
        //GetComponent<BoxCollider>().enabled = true;
    }

    /*
    
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {

            if (carry == false) { 
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().freezeRotation = true;
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
            carry = true;
            }
            else if (carry == true)
            {
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().freezeRotation = false;
                carry = false;
            }

        }
    }
    */
}
