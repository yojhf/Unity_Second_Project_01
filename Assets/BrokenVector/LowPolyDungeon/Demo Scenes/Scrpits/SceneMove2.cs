using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("부딛힘");
        if (collision.tag == "Player")
        {
            Debug.Log("씬 이동!");
            SceneManager.LoadScene("Dungeon_Stage3");
        }
    }
}
