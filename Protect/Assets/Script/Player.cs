using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        LookAt();
    }

    public void LookAt()
    {
        Vector3 mPosition = Input.mousePosition;
        Vector3 oPosition = transform.position;

        Vector3 target = Camera.main.ScreenToWorldPoint(mPosition);
        target.y = oPosition.y;

        transform.LookAt(target);
    }

 
}