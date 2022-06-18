using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Btn_2 : MonoBehaviour
{
    [SerializeField] GameObject Btn_red;
    [SerializeField] GameObject Btn_brown;
    [SerializeField] GameObject Btn_green;

    private Stage3_Door_open2 script;

    bool clicksc = false;
    public string colorsc = "";

    // Start is called before the first frame updsate
    void Start()
    {
        script = GameObject.Find("Player").GetComponent<Stage3_Door_open2>();
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
                    clicksc = true;
                    colorsc = "green";
                }
                if (hit.transform.gameObject.name == "btn_red")
                {
                    clicksc = true;
                    colorsc = "red";
                }
                if (hit.transform.gameObject.name == "btn_brown")
                {
                    clicksc = true;
                    colorsc = "brown";
                }
                script.open_doorsc();
            }
        }

    }
    void LateUpdate()
    {
        if(clicksc == true){
            click_eventsc();
        }else{
            if( colorsc == "red"){
                Btn_red.transform.position = new Vector3(-36.751f, 7.971f, 34.467f);
            }
            if( colorsc == "green"){
                Btn_green.transform.position = new Vector3(-33.53f, 7.934f, 32.31f);
            }
            if( colorsc == "brown"){
                Btn_brown.transform.position = new Vector3(-39.8f, 7.987f, 32.25f);
            }
        }
    }

    void click_eventsc(){
        if (clicksc && colorsc == "red"){
            Btn_red.transform.position = new Vector3(-36.751f, 7.917f, 34.467f);
            
            Invoke("delaysc", 0.5f);
        }
        if (clicksc && colorsc == "green"){
            Btn_green.transform.position = new Vector3(-33.53f, 7.872f, 32.31f);
            
            Invoke("delaysc", 0.5f);
        }
        if (clicksc && colorsc == "brown"){
            Btn_brown.transform.position = new Vector3(-39.8f, 7.893f, 32.25f);
            
            Invoke("delaysc", 0.5f);
        }
    }

    void delaysc(){
        clicksc = false;
    }
}
