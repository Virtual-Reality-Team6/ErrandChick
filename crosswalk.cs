using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosswalk : MonoBehaviour
{
    public GameObject Player;

    public GameObject subbox1;
    public GameObject subbox2;
    public GameObject subbox3;
    public GameObject subbox4;
    public GameObject subbox5;

    public GameObject clear;
    public GameObject fail;

    //public GameObject ori;
    public GameObject dst;

    private WaitForSeconds _UIDelay1 = new WaitForSeconds(1.5f);
    private float distance;
    bool timeup;
    bool success;

    // Start is called before the first frame update
    void Start()
    {
        timeup = false;
        success = false;

        clear.SetActive(false);
        fail.SetActive(false);

        subbox1.SetActive(true);
        subbox2.SetActive(true);
        subbox3.SetActive(true);
        subbox4.SetActive(true);
        subbox5.SetActive(true);

        StopAllCoroutines();
        StartCoroutine(delay1());


    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, dst.transform.position);

        if (distance <= 5f)
        {
            Debug.Log("great job!");
            success = true;
            StopCoroutine("delay1");
            StartCoroutine(clear1());
            StopAllCoroutines();


        }


    }

    IEnumerator delay1()
    {
        yield return _UIDelay1;
        subbox1.SetActive(false);

        yield return _UIDelay1;
        subbox2.SetActive(false);

        yield return _UIDelay1;
        subbox3.SetActive(false);

        yield return _UIDelay1;
        subbox4.SetActive(false);

        yield return _UIDelay1;
        subbox5.SetActive(false);

        Debug.Log("times up!");
        timeup = true;

        fail.SetActive(true);
        yield return _UIDelay1;
        fail.SetActive(false);

    }

    IEnumerator clear1()
    {
        clear.SetActive(true);
        yield return _UIDelay1;
        clear.SetActive(false);
    }


}
