using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf2 : MonoBehaviour
{
    [SerializeField] GameObject objsc1; // 1
    [SerializeField] GameObject objsc2; // 1
    [SerializeField] GameObject objsc3; // 6
    [SerializeField] GameObject objsc4;
    [SerializeField] GameObject objsc5;
    [SerializeField] GameObject lightsc;
    [SerializeField] GameObject lightsc2;

    static bool[] check = new bool[] { false, false, false, false, false };
    // private Re_object script;

    // Start is called before the first frame update
    void Start()
    {
        // script = GameObject.Find("Shelf_Wall").GetComponent<Re_object>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void shelfCheck()
    {
        Debug.Log("½ÇÇà");
        bool flag = false;
        check[0] = objsc1.GetComponent<Renderer>().enabled;
        check[1] = objsc2.GetComponent<Renderer>().enabled;
        check[2] = objsc3.GetComponent<Renderer>().enabled;
        check[3] = objsc4.GetComponent<Renderer>().enabled;
        check[4] = objsc5.GetComponent<Renderer>().enabled;

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(flag);
            if (check[i] == true) { flag = true; }
            if (flag && !check[0] && !check[i])
            {
                Debug.Log("¹º°¡ Àß¸øµÊ");
                objsc1.GetComponent<Renderer>().enabled = false;
                objsc2.GetComponent<Renderer>().enabled = false;
                objsc3.GetComponent<Renderer>().enabled = false;
                objsc4.GetComponent<Renderer>().enabled = false;
                objsc5.GetComponent<Renderer>().enabled = false;

                lightsc.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc.GetComponent<Light>().range = 0.23F;
                lightsc2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[1] && !check[i])
            {
                Debug.Log("¹º°¡ Àß¸øµÊ1");
                objsc1.GetComponent<Renderer>().enabled = true;
                objsc2.GetComponent<Renderer>().enabled = false;
                objsc3.GetComponent<Renderer>().enabled = false;
                objsc4.GetComponent<Renderer>().enabled = false;
                objsc5.GetComponent<Renderer>().enabled = false;

                lightsc.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc.GetComponent<Light>().range = 0.23F;
                lightsc2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[2] && !check[i])
            {
                Debug.Log("¹º°¡ Àß¸øµÊ2");
                objsc1.GetComponent<Renderer>().enabled = true;
                objsc2.GetComponent<Renderer>().enabled = true;
                objsc3.GetComponent<Renderer>().enabled = false;
                objsc4.GetComponent<Renderer>().enabled = false;
                objsc5.GetComponent<Renderer>().enabled = false;

                lightsc.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc.GetComponent<Light>().range = 0.23F;
                lightsc2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[3] && !check[i])
            {
                Debug.Log("¹º°¡ Àß¸øµÊ3");
                objsc1.GetComponent<Renderer>().enabled = true;
                objsc2.GetComponent<Renderer>().enabled = true;
                objsc3.GetComponent<Renderer>().enabled = true;
                objsc4.GetComponent<Renderer>().enabled = false;
                objsc5.GetComponent<Renderer>().enabled = false;

                lightsc.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc.GetComponent<Light>().range = 0.23F;
                lightsc2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[4] && !check[i])
            {
                Debug.Log("¹º°¡ Àß¸øµÊ3");
                objsc1.GetComponent<Renderer>().enabled = true;
                objsc2.GetComponent<Renderer>().enabled = true;
                objsc3.GetComponent<Renderer>().enabled = true;
                objsc4.GetComponent<Renderer>().enabled = true;
                objsc5.GetComponent<Renderer>().enabled = false;

                lightsc.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                lightsc.GetComponent<Light>().range = 0.23F;
                lightsc2.GetComponent<Light>().range = 0.23F;

                return;
            }
        }

        Debug.Log("¾ÆÁ÷ ¹®Á¦¾øÀ½");
        lightsc.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        lightsc2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        lightsc.GetComponent<Light>().range = 0.23F;
        lightsc2.GetComponent<Light>().range = 0.23F;

    }

}
