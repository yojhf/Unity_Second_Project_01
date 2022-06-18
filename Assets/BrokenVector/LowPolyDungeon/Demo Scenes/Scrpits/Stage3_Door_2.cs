using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Door_2 : MonoBehaviour
{
    [SerializeField] GameObject switch_bar;
    public static bool pushsc = false;
    private Stage3_TextUI2 script;

    // Start is called before the first frame updsate
    void Start()
    {
        script = GameObject.Find("Switch_Lever2").GetComponent<Stage3_TextUI2>();

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
                if (hit.transform.gameObject.name == "Switch_Lever2")
                {
                    pushsc = true;
                }
            }
        }

    }
    void LateUpdate()
    {
        if (pushsc)
        {
            switch_bar.GetComponent<Stage3_TextUI2>().enabled = true;
            script.typing_startsc();
            // switch_bar.transform.localEulerAngles = new Vector3(20, 00, 0);
            pushsc = false;
        }
        else
        {
            switch_bar.GetComponent<Stage3_TextUI2>().enabled = false;
            // switch_bar.transform.localEulerAngles = new Vector3(-41.869f, 00, 0);
        }
    }
}
