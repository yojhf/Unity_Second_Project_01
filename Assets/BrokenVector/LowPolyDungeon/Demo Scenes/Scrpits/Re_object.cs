using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re_object : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject obj1; // 1
    // [SerializeField] GameObject obj2; // 1
    // [SerializeField] GameObject obj3; // 6
    // [SerializeField] GameObject obj4;
    // [SerializeField] GameObject obj5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void instatiation_object()
    {
        // Destroy(obj1);
        // Destroy(obj2);
        // Destroy(obj3);
        // Destroy(obj4);
        // Destroy(obj5);
        Instantiate(obj1, new Vector3(-15.13f, 5.04f, -15.01f), Quaternion.identity);
        // Instantiate(obj2, new Vector3(-25.61f, 4.94f, -7.29f), Quaternion.identity);
        // Instantiate(obj3, new Vector3(-21.88f, 5.30f, 0.49f), Quaternion.identity);
        // Instantiate(obj4, new Vector3(-25.97f, 5.79f, -10.71f), Quaternion.identity);
        // Instantiate(obj5, new Vector3(-30.28f, 5.01f, -16.74f), Quaternion.identity);
    }
}
