using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VIDE_Data;
public class StoryEffects : MonoBehaviour
{

    [SerializeField] GameObject TransitionBox;
    [SerializeField] GameObject buttonNext;
    [SerializeField] GameObject miniLO;
    [SerializeField] GameObject miniSP;
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

    [Space]
    [SerializeField] VIDE_Assign dialogManager;

    [Space]
    [SerializeField] bool isLightsOutDone;
    [SerializeField] bool isSlidingPuzzleDone;

    private void Start()
    {
        isLightsOutDone = false;
        isSlidingPuzzleDone = false;

        ShowText("Act I");
        StartNarration(0);
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

    public void StartNarration(int pos)
    {
        PlayerNarration.Stop();
        PlayerNarration.clip = narration_list[pos];
        PlayerNarration.Play();
    }

    public void StartBGM(int pos)
    {
        PlayerBGM.Stop();
        PlayerBGM.clip = BGM_list[pos];
        PlayerBGM.Play();
    }

    public void StartSound(int pos)
    {
        Debug.Log("testytest");
        PlayerSoundEffect.Stop();
        PlayerSoundEffect.clip = SFX_list[pos];
        PlayerSoundEffect.Play();
    }

    public void ChangeVolumeNarration(float vol)
    {
        PlayerNarration.volume = vol;
    }

    public void ChangeVolumeBGM(float vol)
    {
        PlayerBGM.volume = vol;
    }

    public void ChangeVolumeSound(float vol)
    {
        PlayerSoundEffect.volume = vol;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadDialogue("Act1Scene1");
        }
    }

    public void LoadDialogue(string dialogueName)
    {
        dialogManager.AssignNew(dialogueName);
    }

    public void StartLightsOut()
    {
        buttonNext.SetActive(false);
        miniLO.SetActive(true);
    }
}
