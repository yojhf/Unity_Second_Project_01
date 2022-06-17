using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    [SerializeField] GameObject obj1; // 1
    [SerializeField] GameObject obj2; // 1
    [SerializeField] GameObject obj3; // 6
    [SerializeField] GameObject obj4;
    [SerializeField] GameObject obj5;
    [SerializeField] GameObject light;
    [SerializeField] GameObject light2;

    static bool[] check = new bool[] { false, false, false, false, false };
    // private Re_object script;
    public int obj_count = 0;

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
        Debug.Log("실행");
        bool flag = false;
        check[0] = obj1.GetComponent<Renderer>().enabled;
        check[1] = obj2.GetComponent<Renderer>().enabled;
        check[2] = obj3.GetComponent<Renderer>().enabled;
        check[3] = obj4.GetComponent<Renderer>().enabled;
        check[4] = obj5.GetComponent<Renderer>().enabled;

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(flag);
            if(check[i] == true) { flag = true;}
            if (flag && !check[0] && !check[i])
            {
                Debug.Log("뭔가 잘못됨");
                obj1.GetComponent<Renderer>().enabled = false;
                obj2.GetComponent<Renderer>().enabled = false;
                obj3.GetComponent<Renderer>().enabled = false;
                obj4.GetComponent<Renderer>().enabled = false;
                obj5.GetComponent<Renderer>().enabled = false;

                light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[1] && !check[i])
            {
                Debug.Log("뭔가 잘못됨1");
                obj1.GetComponent<Renderer>().enabled = true;
                obj2.GetComponent<Renderer>().enabled = false;
                obj3.GetComponent<Renderer>().enabled = false;
                obj4.GetComponent<Renderer>().enabled = false;
                obj5.GetComponent<Renderer>().enabled = false;

                light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[2] && !check[i])
            {
                Debug.Log("뭔가 잘못됨2");
                obj1.GetComponent<Renderer>().enabled = true;
                obj2.GetComponent<Renderer>().enabled = true;
                obj3.GetComponent<Renderer>().enabled = false;
                obj4.GetComponent<Renderer>().enabled = false;
                obj5.GetComponent<Renderer>().enabled = false;

                light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[3] && !check[i])
            {
                Debug.Log("뭔가 잘못됨3");
                obj1.GetComponent<Renderer>().enabled = true;
                obj2.GetComponent<Renderer>().enabled = true;
                obj3.GetComponent<Renderer>().enabled = true;
                obj4.GetComponent<Renderer>().enabled = false;
                obj5.GetComponent<Renderer>().enabled = false;

                light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().range = 0.23F;

                return;
            }
            else if (flag && !check[4] && !check[i])
            {
                Debug.Log("뭔가 잘못됨3");
                obj1.GetComponent<Renderer>().enabled = true;
                obj2.GetComponent<Renderer>().enabled = true;
                obj3.GetComponent<Renderer>().enabled = true;
                obj4.GetComponent<Renderer>().enabled = true;
                obj5.GetComponent<Renderer>().enabled = false;

                light.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light2.GetComponent<Light>().color = new Color(255, 0, 0, 255);
                light.GetComponent<Light>().range = 0.23F;
                light2.GetComponent<Light>().range = 0.23F;

                return;
            }
            //else if ()
            //{
            //    Debug.Log("완료");
            //    obj1.GetComponent<Renderer>().enabled = true;
            //    obj2.GetComponent<Renderer>().enabled = true;
            //    obj3.GetComponent<Renderer>().enabled = true;
            //    obj4.GetComponent<Renderer>().enabled = true;
            //    obj5.GetComponent<Renderer>().enabled = true;
            //}
        }

        Debug.Log("아직 문제없음");
        light.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        light2.GetComponent<Light>().color = new Color(0, 255, 0, 255);
        light.GetComponent<Light>().range = 0.23F;
        light2.GetComponent<Light>().range = 0.23F;
        obj_count += 1;
        Debug.Log(obj_count);
        if(obj_count == 5){
            Debug.Log(obj_count);
            Debug.Log("문열림");
            light.GetComponent<Light>().color = new Color(0, 255, 255, 255);
            light2.GetComponent<Light>().color = new Color(0, 255, 255, 255);
        }
    }
}