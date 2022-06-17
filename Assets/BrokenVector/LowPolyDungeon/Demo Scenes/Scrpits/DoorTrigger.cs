using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject door1_1;
    [SerializeField] GameObject light;



    public int h_count = 0;
    public static int floor = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(h_count);
        Debug.Log(floor);
    }

    void OnTriggerEnter(Collider other)
    {
        //첫번째 트리거
        if(floor == 0 && h_count == 1){
            floor += 1;
            light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }

        if(floor == 1 && h_count == 2){
            floor += 1;
            light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(floor == 1 && h_count == 3){
            floor = 0;
            light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        }

        if(floor == 2 && h_count == 3){
            floor += 1;
            light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(floor == 2 && h_count == 1){
            floor = 0;
            light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        }

        Debug.Log("floor : " + floor);
        Debug.Log("h_count : "+h_count);
        

        if(floor == 3 && h_count == 3)
        {
            door.transform.localEulerAngles = new Vector3(0, 0, 0);
            door1_1.transform.localEulerAngles = new Vector3(0, 180, 0);
            light.GetComponent<Light>().color = new Color(0, 255, 255, 255);
            light.GetComponent<Light>().range = 0.8F;
            Debug.Log("작동");
        }


      
    }
}
