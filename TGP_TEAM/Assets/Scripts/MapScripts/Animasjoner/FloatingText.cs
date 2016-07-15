using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour {
    public Animator animator;
    private Text damageText;

    void OnEnable()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0); //Finner frem klippet
        Destroy(gameObject, clipInfo[0].clip.length); //Ødelegger objektet ETTER at klippet er spilt av.
        damageText = animator.GetComponent<Text>();
    }

    public void SetText(string text)
    {
        damageText.text = text;
    }
}