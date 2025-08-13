using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageIndicator : MonoBehaviour
{

    public Image image;
    public float flashSpeed;

    private Coroutine Coroutine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterManager.Instance.Player.condition.onTakeDamage += Flash;
    }
    public void Flash()
    {
        if (Coroutine != null)
        {
            StopCoroutine(Coroutine);
        }
        image.enabled = true;
        image.color = new Color(1f, 100f / 255f, 100f / 255f);
        Coroutine =StartCoroutine(FadeAway());
    }
    private IEnumerator FadeAway()
    {
        float startAlpha = 0.3f;
        float a = startAlpha;

        while (a > 0)
        {
            a -= Time.deltaTime * (startAlpha/ flashSpeed);
            image.color = new Color(1f, 100f/255f, 100f/255f, a);
            yield return null;
        }
        image.enabled = false;
    }
}
