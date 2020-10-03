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
        RectTransform rect = self.GetComponent<RectTransform>();

        Vector3[] v = new Vector3[4];
        rect.GetWorldCorners(v);
        float size = v[0].y - v[1].y;
        size = Mathf.Abs(size);

        if (Vector3.Distance(placeholder, slot.transform.position) <= size)
        {
            self.transform.position = slot.transform.position;
            slot.transform.position = placeholder;
            slideMaster.UpdatePos(self);
        }
    }
}
