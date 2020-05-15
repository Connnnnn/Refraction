using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Gate1;
    public GameObject DoorL1;
    public GameObject BR1;
    public bool R1;

    public GameObject Gate2;
    public GameObject DoorL2;
    public GameObject YR1;
    public bool R2;


    void Update()
    {
        Receiver TestScript = BR1.GetComponent<Receiver>();
        //If all lasers hitting recievers then raise the door
        
        if (TestScript.HIT)
        {
            Debug.Log("R1 DONE");
            if (Gate1.transform.position.y < 8)
            {
                Gate1.transform.Translate(Vector3.up * Time.deltaTime, Space.World);

                DoorL1.SetActive(false);
            }
            
        }
       //if not, keep it close or lower it
        else {

            if (Gate1.transform.position.y > 2)
            {
                Gate1.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                DoorL1.SetActive(true);
            }
        }
        
    }
}
