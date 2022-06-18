using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Door_open2 : MonoBehaviour
{
    // [SerializeField] GameObject Btn_red;
    // [SerializeField] GameObject Btn_green;
    // [SerializeField] GameObject Btn_brown;
    [SerializeField] GameObject Door;
    [SerializeField] GameObject Door2;
    [SerializeField] GameObject Door3;
    [SerializeField] GameObject light2;

    private Stage3_Btn_2 script;

    public int countsc = 0;
    int [] keysc = new [] {2,3,2,1,3,2,2,1};
    public int h_countsc = 0;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Player").GetComponent<Stage3_Btn_2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void open_doorsc(){
        if(script.colorsc == "red"){
            countsc = 1;
        }
        if(script.colorsc == "green"){
            countsc = 2;
        }
        if(script.colorsc == "brown"){
            countsc = 3;
        }

        if(countsc == keysc[0] && h_countsc == 0){
            Debug.Log("순서작동");
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[1] && h_countsc == 1){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[2] && h_countsc == 2){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[3] && h_countsc == 3){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[4] && h_countsc == 4){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[5] && h_countsc == 5){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[6] && h_countsc == 6){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else if(countsc == keysc[7] && h_countsc == 7){
            h_countsc += 1;
            light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        }
        else{
            h_countsc = 0;
            light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        }

        if(h_countsc == 8){
            Door.transform.localEulerAngles = new Vector3(0, 180, 0);
            Door2.transform.localEulerAngles = new Vector3(0, 0, 0);
            Door3.transform.localEulerAngles = new Vector3(0, -90, 0);
            light2.GetComponent<Light>().color = new Color(0, 255, 255, 255);
        }

    }
}
