using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Object : MonoBehaviour
{
    [SerializeField] GameObject obj1; // 1
    [SerializeField] GameObject obj2; // 1
    [SerializeField] GameObject wood; // 6

    private Shelf script;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Shelf_Wall").GetComponent<Shelf>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == wood.tag)
        {
            obj2.GetComponent<Renderer>().enabled = true; // 렌더
            script.shelfCheck(); // 순서체크(렌더 필요)
            if(obj2.GetComponent<Renderer>().enabled == true){
                Destroy(obj1);
            }
        }
    }
}