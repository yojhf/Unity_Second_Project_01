using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Door_open1 : MonoBehaviour
{
    // [SerializeField] GameObject Btn_red;
    // [SerializeField] GameObject Btn_green;
    // [SerializeField] GameObject Btn_brown;
    [SerializeField] GameObject Door;

    private Stage3_Btn_1 script;

    public int count = 0;
    int [] key = new [] {1,2,3,2,1,2};
    int h_count = 0;
    // {1,2,3,2,1,2}

    // Start is called before the first frame update
    void Start()
    {
        btn_script = GameObject.Find("Player").GetComponent<Stage3_Btn_1>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(h_count);
        Debug.Log(count);
    }

    void open_door(){
        if(btn_script.color == "red"){
            count = 1;
        }
        if(btn_script.color == "green"){
            count = 2;
        }
        if(btn_script.color == "brown"){
            count = 3;
        }

        if(count == key[0]){
            h_count += 1;
        }
        if(count == key[1] && h_count == 1){
            h_count += 1;
        }else{
            h_count = 0;
        }
        if(count == key[2] && h_count == 2){
            h_count += 1;
        }else{
            h_count =0;
        }
        if(count == key[3] && h_count == 3){
            h_count += 1;
        }else{
            h_count =0;
        }
        if(count == key[4] && h_count == 4){
            h_count += 1;
        }else{
            h_count =0;
        }
        if(count == key[5] && h_count == 5){
            h_count += 1;
        }else{
            h_count =0;
        }

    }
}
