using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carroad : MonoBehaviour
{
    public GameObject subbox2;
    private WaitForSeconds _UIDelay1 = new WaitForSeconds(0.5f);

    // Start is called before the first frame update
    void Start()
    {
        subbox2.SetActive(false);
    }


    public void OnClickButton()
    {
        Debug.Log("Wrong choice!");
        StopAllCoroutines();
        StartCoroutine(delay2());
        StopAllCoroutines();
    }


    IEnumerator delay2()
    {
        subbox2.SetActive(true);
        yield return _UIDelay1;
        subbox2.SetActive(false);
    }

}
