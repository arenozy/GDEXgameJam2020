using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryEffects : MonoBehaviour
{

    [SerializeField] GameObject TransitionBox;
    public float time = 0.001f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(IFadeIn());
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(IFadeOut());
        }
    }

    public void FadeIn()
    {
        StopCoroutine(IFadeOut());
        StartCoroutine(IFadeIn());
    }

    public void FadeOut()
    {
        StopCoroutine(IFadeIn());
        StartCoroutine(IFadeOut());
    }

    IEnumerator IFadeIn()
    {
        Debug.Log("Started");
        Color color = TransitionBox.GetComponent<Image>().color;

        while(color.a > 0)
        {
            color.a -= 0.02f;
            TransitionBox.GetComponent<Image>().color = color;
            yield return new WaitForSeconds(time);
        }
        Debug.Log("Stopped");
    }

    IEnumerator IFadeOut()
    {
        Debug.Log("Started");
        Color color = TransitionBox.GetComponent<Image>().color;

        while (color.a < 1)
        {
            color.a += 0.02f;
            TransitionBox.GetComponent<Image>().color = color;
            yield return new WaitForSeconds(time);
        }
        Debug.Log("Stopped");
    }
}
