using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage3_TextUI1 : MonoBehaviour
{
    [SerializeField] GameObject switch_bar;
    public Text tx;
    private string m_Text = "빨간색-초록색-갈색-초록색-빨강색-초록색";
    // Start is called before the first frame update
    bool trick = false;

    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void typing_start(){
        if(trick == false){
            StartCoroutine(typing());
        }
    }

    public IEnumerator typing()
    {
        Debug.Log(trick);
        trick = true;
        switch_bar.transform.localEulerAngles = new Vector3(20, 00, 0);
        Debug.Log(trick);
        for (int i = 0; i <= m_Text.Length; i++)
        {
            // Debug.Log(i + "아이");
            tx.text = m_Text.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
        tx.text = "";
        trick = false;
        yield return new WaitForSeconds(5.0f);
        switch_bar.transform.localEulerAngles = new Vector3(-41.869f, 00, 0);
    }
}
