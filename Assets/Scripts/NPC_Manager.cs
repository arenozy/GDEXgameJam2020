using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Backstage")]
    [SerializeField] GameObject EstelleB;
    [SerializeField] GameObject DanielB;
    [SerializeField] GameObject ThomasB;
    [SerializeField] GameObject MckenzieB;
    [SerializeField] GameObject SamanthaB;

    [Header("Lobby")]
    [SerializeField] GameObject EstelleL;
    [SerializeField] GameObject DanielL;
    [SerializeField] GameObject ThomasL;
    [SerializeField] GameObject MckenzieL;
    [SerializeField] GameObject SamanthaL;

    [Header("Theatre")]
    [SerializeField] GameObject EstelleT;
    [SerializeField] GameObject DanielT;
    [SerializeField] GameObject ThomasT;
    [SerializeField] GameObject MckenzieT;
    [SerializeField] GameObject SamanthaT;

    public void Estelle_On(string thingy)
    {
        if(thingy.ToUpper().Substring(0, 1) == "B")
        {
            EstelleB.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            EstelleT.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            EstelleL.SetActive(true);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Estelle_Off(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            EstelleB.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            EstelleT.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            EstelleL.SetActive(false);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Daniel_On(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            DanielB.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            DanielT.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            DanielL.SetActive(true);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Daniel_Off(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            DanielB.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            DanielT.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            DanielL.SetActive(false);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Thomas_On(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            ThomasB.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            ThomasT.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            ThomasL.SetActive(true);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Thomas_Off(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            ThomasB.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            ThomasT.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            ThomasL.SetActive(false);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Mckenzie_On(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            MckenzieB.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            MckenzieT.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            MckenzieL.SetActive(true);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Mckenzie_Off(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            MckenzieB.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            MckenzieT.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            MckenzieL.SetActive(false);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Samantha_On(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            SamanthaB.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            SamanthaT.SetActive(true);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            SamanthaL.SetActive(true);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void Samantha_Off(string thingy)
    {
        if (thingy.ToUpper().Substring(0, 1) == "B")
        {
            SamanthaB.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "T")
        {
            SamanthaT.SetActive(false);
        }
        else if (thingy.ToUpper().Substring(0, 1) == "L")
        {
            SamanthaL.SetActive(false);
        }
        else
        {
            Debug.LogError("CHIP, someone didnt type a letter properly!");
        }
    }

    public void AllOff()
    {
        EstelleB.SetActive(false);
        EstelleL.SetActive(false);
        EstelleT.SetActive(false);

        DanielB.SetActive(false);
        DanielL.SetActive(false);
        DanielT.SetActive(false);

        ThomasB.SetActive(false);
        ThomasL.SetActive(false);
        ThomasT.SetActive(false);

        MckenzieB.SetActive(false);
        MckenzieL.SetActive(false);
        MckenzieT.SetActive(false);

        SamanthaB.SetActive(false);
        SamanthaL.SetActive(false);
        SamanthaT.SetActive(false);
    }
}
