using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2 : MonoBehaviour
{

    [SerializeField] GameObject door2;
    [SerializeField] GameObject light2;


    public int h_count = 0;
    public static int floor_2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // 2번째 트리거
        if (floor_2 == 0 && h_count == 1)
        {
            floor_2 += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }

        if (floor_2 == 1 && h_count == 2)
        {
            floor_2 += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if (floor_2 == 1 && h_count == 3)
        {
            floor_2 = 0;
            light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        }

        if (floor_2 == 2 && h_count == 3)
        {
            floor_2 += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if (floor_2 == 2 && h_count == 1)
        {
            floor_2 = 0;
            light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        }

        Debug.Log("floor_2 : " + floor_2);
        Debug.Log("h_count : " + h_count);


        if (floor_2 == 3 && h_count == 3)
        {
            door2.transform.localEulerAngles = new Vector3(0, 0, 0);
            light2.GetComponent<Light>().color = new Color(0, 255, 255, 255);
            light2.GetComponent<Light>().range = 0.8F;
            Debug.Log("작동");
        }
    }
}
