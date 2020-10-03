using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public List<GameObject> NodeList = new List<GameObject>();

    public GameObject CurrentNode;

    [SerializeField] GameObject mouseBlocker;

    [SerializeField] GameObject backstage;
    [SerializeField] GameObject theatre;
    [SerializeField] GameObject lobby;

    // Start is called before the first frame update
    void Start()
    {
        mouseBlocker.SetActive(false);
        UpdateNodeList();
    }

    public void UpdateNodeList()
    {
        NodeList.Clear();
        NodeList.AddRange(GameObject.FindGameObjectsWithTag("Node"));
    }

    public void LerpToNewNode(GameObject newNode)
    {
        float transitionTime = 3.0f;
        StartCoroutine(ILerpToNewNode(newNode, transitionTime));
    }

    IEnumerator ILerpToNewNode(GameObject newNode, float transitionTime)
    {
        CurrentNode = newNode;
        mouseBlocker.SetActive(true);

        Camera main = Camera.main;

        float elapsedTime = 0.0f;

        while (elapsedTime < transitionTime)
        {
            main.transform.position = Vector3.Lerp(main.transform.position, newNode.transform.position, (elapsedTime / transitionTime));
            main.transform.rotation = Quaternion.Slerp(main.transform.rotation, newNode.transform.rotation, (elapsedTime / transitionTime));

            elapsedTime += Time.deltaTime;
            yield return new WaitForSeconds(0.01f);

            if(main.transform.position == newNode.transform.position && Quaternion.Dot(main.transform.rotation, newNode.transform.rotation) > 0.99f)
            {
                Debug.Log("Break");
                break;
            }
        }

        main.transform.position = newNode.transform.position;
        main.transform.rotation = newNode.transform.rotation;

        mouseBlocker.SetActive(false);
    }

    public void moveToLobby()
    {
        LerpToNewNode(lobby);
    }

    public void moveToTheatre()
    {
        LerpToNewNode(theatre);
    }

    public void moveToBackstage()
    {
        LerpToNewNode(backstage);
    }
}
