using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;

    Vector3 moveVec;

    Animator anim;

    private Vector3 targetPosition;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        //targetPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

        transform.position += moveVec * speed * Time.deltaTime;

        anim.SetBool("Run", moveVec != Vector3.zero);
        //anim.SetBool("Walk", wDown);

        transform.LookAt(transform.position+moveVec);

    }
    


}
