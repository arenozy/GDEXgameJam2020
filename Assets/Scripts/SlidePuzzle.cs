using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SlidePuzzle : MonoBehaviour
{
    [SerializeField] GameObject slot;
    [SerializeField] SlideMaster slideMaster;
    public Vector3 origPos;

    private void Start()
    {
        slideMaster = transform.parent.GetComponent<SlideMaster>();
        origPos = transform.position;
        slideMaster.UpdatePos(this.gameObject);
    }
    public void SlideToSlot(GameObject self)
    {
        Vector3 placeholder = self.transform.position;
        Debug.Log(Vector3.Distance(placeholder, slot.transform.position));
        if (Vector3.Distance(placeholder, slot.transform.position) < 55)
        {
            self.transform.position = slot.transform.position;
            slot.transform.position = placeholder;
            slideMaster.UpdatePos(self);
        }
    }
}
