using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Object2 : MonoBehaviour
{
    [SerializeField] GameObject objsc1; // 1
    [SerializeField] GameObject objsc2; // 1
    [SerializeField] GameObject woodsc; // 6

    private Shelf2 script;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Shelf_Wall2").GetComponent<Shelf2>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == woodsc.tag)
        {
            objsc2.GetComponent<Renderer>().enabled = true; // ·»´õ
            script.shelfCheck(); // ¼ø¼­Ã¼Å©(·»´õ ÇÊ¿ä)
            if (objsc2.GetComponent<Renderer>().enabled == true)
            {
                Destroy(objsc1);
            }
        }
    }
}
