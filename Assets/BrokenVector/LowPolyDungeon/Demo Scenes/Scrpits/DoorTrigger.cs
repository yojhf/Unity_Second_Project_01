using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;
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

    }

    void OnTriggerEnter(Collider other)
    {
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
            light.GetComponent<Light>().color = new Color(0, 255, 255, 255);
            light.GetComponent<Light>().range = 4.5F;
            Debug.Log("작동");
        }
    }
}
