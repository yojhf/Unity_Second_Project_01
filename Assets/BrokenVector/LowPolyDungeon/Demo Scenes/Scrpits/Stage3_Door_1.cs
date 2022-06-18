using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_Door_1 : MonoBehaviour
{
    [SerializeField] GameObject switch_bar;
    public static bool push = false;
    private Stage3_TextUI1 script;
    public float rotateSpeed = 5.0f;


    // Start is called before the first frame updsate
    void Start()
    {
        script = GameObject.Find("Switch_Lever1").GetComponent<Stage3_TextUI1>();

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
                if (hit.transform.gameObject.name == "Switch_Lever1")
                {
                    push = true;
                }
            }
        }

    }
    void LateUpdate()
    {
        if (push)
        {
            Debug.Log("¤¸¤§");
            Debug.Log(switch_bar.GetComponent<Stage3_TextUI1>().enabled + "Àü");
            switch_bar.GetComponent<Stage3_TextUI1>().enabled = true;
            script.Start();
            Debug.Log(switch_bar.GetComponent<Stage3_TextUI1>().enabled + "ÈÄ");
            switch_bar.transform.localEulerAngles = new Vector3(20, 00, 0);
            push = false;
        }
        else
        {
            switch_bar.GetComponent<Stage3_TextUI1>().enabled = false;
            switch_bar.transform.localEulerAngles = new Vector3(-41.869f, 00, 0);


        }

    }
}
