using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Canvas: MonoBehaviour {

   [Header ("투명도 값 변화 학인을 위한 슬라이더")]
   [Range(0f, 1f)]
    public float opacity = 1;

    [Header("실제 데이터는 함수 FaidIn, FadeOut으로 접근")]
    CanvasRenderer[] cRend;


    private float startTime = 0;
    private float startOpacity = 1;
    private int endOpacity = 1;
    private float duration = 0;
    private bool isFading = false;


    private void Awake()
    {
        cRend = GetComponentsInChildren<CanvasRenderer>();
        onAlphachanged += SetcRendAlpha;
    }

    public delegate void DelegateFunction(float alpha);
    public DelegateFunction onAlphachanged = null;

    private float _alphaValue;

     //get, set 을 사용하면 코드 내부의 데이터 값이 변할때 실행되는 함수를 만들수 있습니다. 
     public float alphaValue
    {
        get { return _alphaValue; }
        set
        {
             onAlphachanged(value);  //실행하고자 하는 함수 (여기는 델리게이트 타입으로 일단 구현해보았지만, 직접 함수 호출해도 됩니다. )
             _alphaValue = value;
        }
    }

    public void SetcRendAlpha(float val)
    {
        foreach (CanvasRenderer nRend in cRend)
        {
            nRend.SetAlpha(val);
        }
    }


    public void FadeIn(float duration = 0.5f)
    {
        StopCoroutine(FadeAnimation());

        this.duration = duration;
        this.startTime = Time.time;
        this.startOpacity = 0;
        this.endOpacity = 1;
        this.isFading = true;
        
        StartCoroutine(FadeAnimation(duration));
    }

    public void FadeOut(float duration = 0.5f)
    {
        StopCoroutine(FadeAnimation());

        this.duration = duration;
        this.startTime = Time.time;
        this.startOpacity = 1;
        this.endOpacity = 0;
        this.isFading = true;

        StartCoroutine(FadeAnimation(duration));
    }

    void FadeInOut()
    {
        if (isFading && duration > 0)
        {
            alphaValue = Mathf.Lerp(startOpacity, endOpacity, (Time.time - startTime) / duration);
            opacity = alphaValue;
            isFading = alphaValue != endOpacity;
        }
    }

    IEnumerator FadeAnimation(float val = 0f)
    {
        float aniTime = 0f;
        while(aniTime < val)
        {
            FadeInOut();
            yield return new WaitForSeconds(0.05f);
            aniTime += 0.05f;
        }
    }

    // 에디터 뷰에서 값 작동이 적용되는거 보는 용도
#if UNITY_EDITOR
    void OnValidate()
     {
        onAlphachanged(opacity);
     }
#endif

}