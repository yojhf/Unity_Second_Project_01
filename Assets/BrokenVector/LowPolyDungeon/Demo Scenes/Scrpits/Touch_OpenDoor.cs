using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject switch_bar;
    bool open = false;
    private Shelf script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Shelf_Wall").GetComponent<Shelf>();
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
                if(hit.transform.gameObject.name == "Switch_Base"){
                    open = true;
                }
            }
        }
    }
    void LateUpdate(){
        if(open && script.obj_count == 5){
            door.transform.localEulerAngles = new Vector3(0, 90, 0);
            switch_bar.transform.localEulerAngles = new Vector3(20, 00, 0);
        }else{
            open = false;
        }
    }
}
