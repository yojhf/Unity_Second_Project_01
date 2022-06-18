using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Btn_1 : MonoBehaviour
{
    [SerializeField] GameObject Btn_red;
    [SerializeField] GameObject Btn_brown;
    [SerializeField] GameObject Btn_green;

    // private Stage3_Door_open1 script;

    bool click = false;
    public static string color = "";

    // Start is called before the first frame updsate
    void Start()
    {
        // script = GameObject.Find("Player").GetComponent<Stage3_Door_open1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
                if (hit.transform.gameObject.name == "btn_green")
                {
                    click = true;
                    color = "green";
                }
                if (hit.transform.gameObject.name == "btn_red")
                {
                    click = true;
                    color = "red";
                }
                if (hit.transform.gameObject.name == "btn_brown")
                {
                    click = true;
                    color = "brown";
                }
                // script.open_door();
            }
        }

    }
    void LateUpdate()
    {
        if(click == true){
            click_event();
        }else{
            if( color == "red"){
                Debug.Log("올려");
                Btn_red.transform.position = new Vector3(-36.751f, 7.971f, 34.467f);
            }
            if( color == "green"){
                Debug.Log("올려");
                Btn_green.transform.position = new Vector3(-33.53f, 7.934f, 32.31f);
            }
            if( color == "brown"){
                Debug.Log("올려");
                Btn_brown.transform.position = new Vector3(-39.8f, 7.987f, 32.25f);
            }
        }
    }

    void click_event(){
        if (click && color == "red"){
            Btn_red.transform.position = new Vector3(-36.751f, 7.917f, 34.467f);
            
            Invoke("delay", 0.5f);
        }
        if (click && color == "green"){
            Btn_green.transform.position = new Vector3(-33.53f, 7.872f, 32.31f);
            
            Invoke("delay", 0.5f);
        }
        if (click && color == "brown"){
            Btn_brown.transform.position = new Vector3(-39.8f, 7.893f, 32.25f);
            
            Invoke("delay", 0.5f);
        }
    }

    void delay(){
        click = false;
    }
}
