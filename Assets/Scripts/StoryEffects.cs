using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryEffects : MonoBehaviour
{

    [SerializeField] GameObject TransitionBox;
    public float time = 0.001f;
    [Space]

    [SerializeField] TextMeshProUGUI actText;

    [Space]
    [SerializeField] AudioSource PlayerBGM;
    [SerializeField] AudioSource PlayerSoundEffect;
    [SerializeField] AudioSource PlayerNarration;

    [Space]
    [SerializeField] List<AudioClip> BGM_list = new List<AudioClip>();
    [SerializeField] List<AudioClip> SFX_list = new List<AudioClip>();
    [SerializeField] List<AudioClip> narration_list = new List<AudioClip>();

    private void Start()
    {
        ShowText("Act I");
        StartNarration(narration_list[0]);
        FadeIn();
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
        Color color = TransitionBox.GetComponent<Image>().color;

        while (color.a > 0)
        {
            color.a -= 0.02f;
            TransitionBox.GetComponent<Image>().color = color;
            yield return new WaitForSeconds(time);
        }
        HideText();
    }

    IEnumerator IFadeOut()
    {
        Color color = TransitionBox.GetComponent<Image>().color;

        while (color.a < 1)
        {
            color.a += 0.02f;
            TransitionBox.GetComponent<Image>().color = color;
            yield return new WaitForSeconds(time);
        }
    }

    public void ShowText(string text)
    {
        actText.gameObject.SetActive(true);
        actText.SetText(text);
    }

    public void HideText()
    {
        actText.gameObject.SetActive(false);
    }

    public void StartNarration(AudioClip narration)
    {
        PlayerNarration.Stop();
        PlayerNarration.clip = narration;
        PlayerNarration.Play();
    }

    public void StartBGM(AudioClip music)
    {
        PlayerBGM.Stop();
        PlayerBGM.clip = music;
        PlayerBGM.Play();
    }

    public void StartSound(AudioClip sound)
    {
        PlayerSoundEffect.Stop();
        PlayerSoundEffect.clip = sound;
        PlayerSoundEffect.Play();
    }
}
