using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Object : MonoBehaviour
{
    [SerializeField] GameObject key_lock; // 1
    [SerializeField] GameObject key_lock_2; // 1
    [SerializeField] GameObject skull; // 2
    [SerializeField] GameObject skull_2; // 2
    [SerializeField] GameObject knife; // 3
    [SerializeField] GameObject knife_2; // 3
    [SerializeField] GameObject goblet; // 4
    [SerializeField] GameObject goblet_2; // 4
    [SerializeField] GameObject key; // 5
    [SerializeField] GameObject key_2; // 5
    [SerializeField] GameObject wood; // 6
    [SerializeField] GameObject light;
    [SerializeField] GameObject light2;
    public int obj = 0;
    public static int obj_count = 0;
    int[] key_code = new int[] {1,2,3,4,5};
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        obj = 0;
        Debug.Log(obj_count);
    }
    void OnTriggerEnter(Collider other)
    {
        if (obj == 1)
        {
            obj_count = 1;
        }
        else if (obj == 2 )
        {
            obj_count = 2;
        }
        else if (obj == 3 )
        {
            obj_count = 3;
        }
        else if (obj == 4 )
        {
            obj_count = 4;
        }
        else if (obj == 5)
        {
            obj_count = 5;
        }
        // else{
        //         Debug.Log("ㅅㅣㅂㅏㄹ");
        //         light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        //         light.GetComponent<Light>().range = 0.23F;
        //         light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        //         light2.GetComponent<Light>().range = 0.23F;
        //     }
       
        if(obj == 6 && obj_count == key_code[obj_count - 1]){
            Debug.Log(obj_count);
            if(obj_count == 1){
                Destroy(key_lock);
                Debug.Log("ㅂㅅ");
                key_lock_2.GetComponent<Renderer>().enabled = true;
                Debug.Log("작동");
                light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light2.GetComponent<Light>().range = 0.23F;
            }
            else if(obj_count == 2){
                Destroy(skull);
                skull_2.GetComponent<Renderer>().enabled = true;
                light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light2.GetComponent<Light>().range = 0.23F;
            }
            else if(obj_count == 3){
                Destroy(knife);
                knife_2.GetComponent<Renderer>().enabled = true;
                light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light2.GetComponent<Light>().range = 0.23F;
            }
            
            else if(obj_count == 4){
                Destroy(goblet);
                goblet_2.GetComponent<Renderer>().enabled = true;
                light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light2.GetComponent<Light>().range = 0.23F;
            }
            else if(obj_count == 5){
                Destroy(key);
                key_2.GetComponent<Renderer>().enabled = true;
                light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
                light2.GetComponent<Light>().range = 0.23F;
            }
        }
        
        // if(obj_count == 2 && num == 1){
        //     Destroy(skull);
        //     num += 1;
        //     skull_2.GetComponent<Renderer>().enabled = true;
        // }// }else{
        //     key_lock_2.GetComponent<Renderer>().enabled = false;
        //     skull_2.GetComponent<Renderer>().enabled = false;
        //     knife_2.GetComponent<Renderer>().enabled = false;
        //     goblet_2.GetComponent<Renderer>().enabled = false;
        //     key_2.GetComponent<Renderer>().enabled = false;
        //     num = 0;
        //     light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        //     light.GetComponent<Light>().range = 0.23F;
        //     light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
        //     light2.GetComponent<Light>().range = 0.23F;
        // // }
        // if(obj == 6 && obj_count == key_code[obj_count - 1]){
        //     if(obj_count == 3 && num == 2){
        //         Destroy(knife);
        //         num += 1;
        //         knife_2.GetComponent<Renderer>().enabled = true;
        //     }
            // }else{
            //     key_lock_2.GetComponent<Renderer>().enabled = false;
            //     skull_2.GetComponent<Renderer>().enabled = false;
            //     knife_2.GetComponent<Renderer>().enabled = false;
            //     goblet_2.GetComponent<Renderer>().enabled = false;
            //     key_2.GetComponent<Renderer>().enabled = false;
            //     num = 0;
            //     light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
            //     light.GetComponent<Light>().range = 0.23F;
            //     light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
            //     light2.GetComponent<Light>().range = 0.23F;
            // }
        // }
        // if(obj == 6 && obj_count == key_code[obj_count - 1]){
        //     if(obj_count == 4 && num == 3){
        //         Destroy(goblet);
        //         num += 1;
        //         goblet_2.GetComponent<Renderer>().enabled = true;
        //     }// }else{
            //     key_lock_2.GetComponent<Renderer>().enabled = false;
            //     skull_2.GetComponent<Renderer>().enabled = false;
            //     knife_2.GetComponent<Renderer>().enabled = false;
            //     goblet_2.GetComponent<Renderer>().enabled = false;
            //     key_2.GetComponent<Renderer>().enabled = false;
            //     num = 0;
            //     light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
            //     light.GetComponent<Light>().range = 0.23F;
            //     light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
            //     light2.GetComponent<Light>().range = 0.23F;
            // }
        // }
        // if(obj == 6 && obj_count == key_code[obj_count - 1]){
        //     if(obj_count == 5 && num == 4){
        //         Destroy(key);
        //         num += 1;
        //         key_2.GetComponent<Renderer>().enabled = true;
        //         light.GetComponent<Light>().color = new Color(0, 255, 255, 255);
        //         light.GetComponent<Light>().range = 0.23F;
        //         light2.GetComponent<Light>().color = new Color(0, 255, 255, 255);
        //         light2.GetComponent<Light>().range = 0.23F;
        //     }// }else{
            //     num = 0;
            //     key_lock_2.GetComponent<Renderer>().enabled = false;
            //     skull_2.GetComponent<Renderer>().enabled = false;
            //     knife_2.GetComponent<Renderer>().enabled = false;
            //     goblet_2.GetComponent<Renderer>().enabled = false;
            //     key_2.GetComponent<Renderer>().enabled = false;
            //     light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
            //     light.GetComponent<Light>().range = 0.23F;
            //     light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
            //     light2.GetComponent<Light>().range = 0.23F;
            // }
        // }
    }
}