using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject Gate1;
    public GameObject DoorL1;
    public GameObject BR1; //Level 1 Receiver
    private bool L1Played;

    public GameObject Gate2;
    public GameObject DoorL2;
    public GameObject YR2; //Level 2 Receiver
    private bool L2Played;

    public GameObject Gate3;
    public GameObject DoorL3;
    public GameObject RR3; //Level 3 Receiver
    private bool L3Played;

    public GameObject Gate4;
    public GameObject DoorL4A;
    public GameObject DoorL4B;
    public GameObject BR4; //Level 4 Receiver Blue
    public GameObject YR4; //Level 4 Receiver Yellow
    private bool L4Played;

    public GameObject Gate5;
    public GameObject DoorL5A;
    public GameObject DoorL5B;
    public GameObject BR5; //Level 5 Receiver Blue
    public GameObject RR5; //Level 5 Receiver Red
    private bool L5Played;


    void Update()
    {

        //ROOM 1 

        Receiver R1Script = BR1.GetComponent<Receiver>();
        //If all lasers hitting recievers then raise the door
        
        if (R1Script.HIT)
        {
            Debug.Log("R1 DONE");
            if (Gate1.transform.position.y < 8)
            {
                Gate1.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                if (L1Played == false)
                {
                    Gate1.GetComponent<AudioSource>().Play();
                    L1Played = true;
                }
                //FindObjectOfType<AudioManager>().Play("LevelComplete");
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



        //ROOM 2

        Receiver R2Script = YR2.GetComponent<Receiver>();
        //If all lasers hitting recievers then raise the door

        if (R2Script.HIT)
        {
            Debug.Log("R2 DONE");
            if (Gate2.transform.position.y < 8)
            {
                Gate2.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                //FindObjectOfType<AudioManager>().Play("LevelComplete");
                if (L2Played == false)
                {
                    Gate2.GetComponent<AudioSource>().Play();
                    L2Played = true;
                }
                DoorL2.SetActive(false);
            }

        }
        //if not, keep it close or lower it
        else
        {

            if (Gate2.transform.position.y > 2)
            {
                Gate2.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                DoorL2.SetActive(true);
            }
        }

        //ROOM 3

        Receiver R3Script = RR3.GetComponent<Receiver>();
        //If all lasers hitting recievers then raise the door

        if (R3Script.HIT)
        {
            Debug.Log("R3 DONE");
            if (Gate3.transform.position.y < 8)
            {
                Gate3.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                //FindObjectOfType<AudioManager>().Play("LevelComplete");
                if (L3Played == false)
                {
                    Gate3.GetComponent<AudioSource>().Play();
                    L3Played = true;
                }
                DoorL3.SetActive(false);
            }

        }
        //if not, keep it close or lower it
        else
        {

            if (Gate3.transform.position.y > 2)
            {
                Gate3.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                DoorL3.SetActive(true);
            }
        }


        //ROOM 4

        Receiver R4ScriptA = BR4.GetComponent<Receiver>();
        Receiver R4ScriptB = YR4.GetComponent<Receiver>();
        //If all lasers hitting recievers then raise the door

        if (R4ScriptA.HIT && R4ScriptB.HIT)
        {
            Debug.Log("R4 DONE");
            if (Gate4.transform.position.y < 8)
            {
                Gate4.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                //FindObjectOfType<AudioManager>().Play("LevelComplete");
                if (L4Played == false)
                {
                    Gate4.GetComponent<AudioSource>().Play();
                    L4Played = true;
                }
                DoorL4A.SetActive(false);
                DoorL4B.SetActive(false);
            }

        }
        //if not, keep it close or lower it
        else
        {

            if (Gate4.transform.position.y > 2)
            {
                Gate4.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                DoorL4A.SetActive(false);
                DoorL4B.SetActive(false);
            }
        }

        //ROOM 5
        
        Receiver R5ScriptA = BR5.GetComponent<Receiver>();
        Receiver R5ScriptB = RR5.GetComponent<Receiver>();
        //If all lasers hitting recievers then raise the door

        Debug.Log("A - " + R5ScriptA.HIT + "B - " + R5ScriptB.HIT);
        if (R5ScriptA.HIT )
        {
            Debug.Log("GM A");
        }

        if (R5ScriptB.HIT)
        {
            Debug.Log("GM B");
        }


        if (R5ScriptA.HIT && R5ScriptB.HIT)
        {
            Debug.Log("R5 DONE");
            if (Gate5.transform.position.y < 8)
            {
                Gate5.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                //FindObjectOfType<AudioManager>().Play("LevelComplete");
                if (L5Played == false)
                {
                    Gate5.GetComponent<AudioSource>().Play();
                    L5Played = true;
                }
                DoorL5A.SetActive(false);
                DoorL5B.SetActive(false);
            }

        }
        //if not, keep it close or lower it
        else
        {

            if (Gate5.transform.position.y > 2)
            {
                Gate5.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                DoorL5A.SetActive(false);
                DoorL5B.SetActive(false);
            }
        }
        


    }
}
