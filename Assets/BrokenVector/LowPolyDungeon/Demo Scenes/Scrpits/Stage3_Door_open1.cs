using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Door_open1 : MonoBehaviour
{
    // [SerializeField] GameObject Btn_red;
    // [SerializeField] GameObject Btn_green;
    // [SerializeField] GameObject Btn_brown;
    [SerializeField] GameObject Door;
    [SerializeField] GameObject light2;

    private Stage3_Btn_1 script;

    public int count = 0;
    int [] key = new [] {1,2,3,2,1,2};
    public int h_count = 0;
    // {1,2,3,2,1,2}

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Player").GetComponent<Stage3_Btn_1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void open_door(){
        if(script.color == "red"){
            count = 1;
        }
        if(script.color == "green"){
            count = 2;
        }
        if(script.color == "brown"){
            count = 3;
        }

        if(count == key[0] && h_count == 0){
            Debug.Log("순서작동");
            h_count += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(count == key[1] && h_count == 1){
            h_count += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(count == key[2] && h_count == 2){
            h_count += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(count == key[3] && h_count == 3){
            h_count += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(count == key[4] && h_count == 4){
            h_count += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(count == key[5] && h_count == 5){
            h_count += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else{
            h_count = 0;
            light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        }

        if(h_count == 6){
            Door.transform.localEulerAngles = new Vector3(0, 180, 0);
            light2.GetComponent<Light>().color = new Color(0, 255, 255, 255);
        }

    }
}
