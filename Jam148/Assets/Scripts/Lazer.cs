using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Lazer : MonoBehaviour
{
    public int reflections;
    public float maxLength;

    public static Lazer instance;

    private LineRenderer lineRenderer;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 direction;


    private void Start()
    {
        instance = this;
        
    }

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        ray = new Ray(transform.position, transform.forward);

        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float remainingLength = maxLength;

        for (int i = 0; i < reflections; i++)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, remainingLength))
            {
                //Debug.Log("Transform Tag is: " + gameObject.tag);
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                remainingLength -= Vector3.Distance(ray.origin,hit.point);
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));

                //Level 1
                GameObject BR1 = GameObject.Find("BR1");
                Receiver Receiver1 = BR1.GetComponent<Receiver>();

                //Level 2
                GameObject YR2 = GameObject.Find("YR2");
                Receiver Receiver2 = YR2.GetComponent<Receiver>();

                //Level 3
                GameObject RR3 = GameObject.Find("RR3");
                Receiver Receiver3 = RR3.GetComponent<Receiver>();

                //Level 4
                GameObject BR4 = GameObject.Find("BR4");
                Receiver Receiver4A = BR4.GetComponent<Receiver>();
                GameObject YR4 = GameObject.Find("YR4");
                Receiver Receiver4B = YR4.GetComponent<Receiver>();

                //Level 5
                GameObject BR5 = GameObject.Find("BR5");
                Receiver Receiver5A = BR5.GetComponent<Receiver>();
                GameObject RR5 = GameObject.Find("RR5");
                Receiver Receiver5B = RR5.GetComponent<Receiver>();

                //BLUE LASER LEVEL 1
                if (gameObject.name == "BL1")
                {
                    if (hit.collider.tag=="BTarget")
                    {
                        Receiver1.HIT = true;
                        break;
                    }
                    else
                    {
                        Receiver1.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }

                //YELLOW LASER LEVEL 2
                else if (gameObject.name == "YL2")
                {
                    if (hit.collider.tag == "YTarget")
                    {
                        Receiver2.HIT = true;
                        break;
                    }
                    else
                    {
                        Receiver2.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }

                //RED LASER LEVEL 3
                else if (gameObject.name == "RL3")
                {
                    if (hit.collider.tag == "RTarget")
                    {
                        Receiver3.HIT = true;
                        break;
                    }
                    else
                    {
                        Receiver3.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }


                //BLUE AND YELLOW LASER - LEVEL 4
                else if (gameObject.name == "BL4")
                {
                    if (hit.collider.tag == "BTarget")
                    {
                        Receiver4A.HIT = true;
                        break;
                    }
                    else
                    {
                        Receiver4A.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }

                else if (gameObject.name == "YL4")
                {
                    if (hit.collider.tag == "YTarget")
                    {
                        Receiver4B.HIT = true;
                        break;
                    }
                    else
                    {
                        Receiver4B.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }

                //BLUE AND RED LASER - LEVEL 5
                else if (gameObject.name == "BL5")
                {
                    if (hit.collider.tag == "BTarget")
                    {
                        Receiver5A.HIT = true;
                        Debug.Log("BLUE " + Receiver5A.HIT);
                        break;
                    }
                    else
                    {
                        Receiver5B.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }

                else if (gameObject.name == "RL5")
                {
                    if (hit.collider.tag == "RTarget")
                    {
                        Receiver5B.HIT = true;
                        Debug.Log("RED "+ Receiver5B.HIT);
                        break;
                    }
                    else
                    {
                        Receiver5B.HIT = false;
                        if (hit.collider.tag != "Mirror")
                        {
                            break;
                        }
                    }
                }

                else if (gameObject.tag == "BLazer"|| gameObject.tag == "YLazer" || gameObject.tag == "RLazer")
                {
                    if (hit.collider.tag != "Mirror")
                    {
                        break;
                    }

                }

            }
            else
            {

                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLength);
            }
        }
    }

}
