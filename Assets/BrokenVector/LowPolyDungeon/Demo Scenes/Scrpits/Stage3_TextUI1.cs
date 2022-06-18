using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage3_TextUI1 : MonoBehaviour
{
    public Text tx;
    private string m_Text = "빨간색-갈색-초록색";
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(_typing());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator _typing()
    {
        yield return new WaitForSeconds(0f);

        
        for (int i = 0; i <= m_Text.Length; i++)
        {
           
            Debug.Log(i + "아이");
            tx.text = m_Text.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
        
        tx.text = "";
        


    }
}
