using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    public GameObject item;
    public GameObject tempParent;
    public Transform dest;

    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnMouseDown()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent <Rigidbody>().isKinematic = true;
        item.transform.position = dest.transform.position;
        item.transform.rotation = dest.transform.rotation;
        item.transform.parent = tempParent.transform;
    }

    private void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = dest.transform.position;
    }
   
}
