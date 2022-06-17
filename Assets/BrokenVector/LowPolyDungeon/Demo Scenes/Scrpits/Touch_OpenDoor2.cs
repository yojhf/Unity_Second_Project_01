using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_OpenDoor2 : MonoBehaviour
{
    [SerializeField] GameObject doorsc;
    [SerializeField] GameObject switch_barsc;
    bool open = false;
    private Shelf2 script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Shelf_Wall2").GetComponent<Shelf2>();
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
                if(hit.transform.gameObject.name == "Switch_Base2"){
                    open = true;
                }
            }
        }
    }
    void LateUpdate(){
        if(open && script.obj_countsc == 5){
            doorsc.transform.localEulerAngles = new Vector3(0, 90, 0);
            switch_barsc.transform.localEulerAngles = new Vector3(20, 00, 0);
        }else{
            open = false;
        }
    }
}
