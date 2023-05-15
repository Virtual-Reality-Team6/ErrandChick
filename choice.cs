using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choice : MonoBehaviour
{
    [Header("SubNotice")]
    public GameObject subbox1;
    public GameObject subbox2;
    //public Text subintext;
    //public Animator subani;

    public GameObject object1;
    public GameObject object2;

    private WaitForSeconds _UIDelay1 = new WaitForSeconds(0.5f);

    void Start()
    {
        subbox1.SetActive(false);
        subbox2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == object2)
                {
                    Debug.Log("Wrong choice!");
                    subbox1.SetActive(false);
                    StopAllCoroutines();
                    StartCoroutine(delay2());
                }
                else if (hit.collider.gameObject == object1)
                {
                    Debug.Log("right choice!");
                    subbox2.SetActive(false);
                    StopAllCoroutines();
                    StartCoroutine(delay1());
                }
            }
        }
    }

    IEnumerator delay1()
    {
        subbox1.SetActive(true);
        yield return _UIDelay1;
        subbox1.SetActive(false);
    }

    IEnumerator delay2()
    {
        subbox2.SetActive(true);
        yield return _UIDelay1;
        subbox2.SetActive(false);
    }
}