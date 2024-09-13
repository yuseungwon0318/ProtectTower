using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject target;
    float angle;
    float speed = 5f;

    private void Start()
    {
        target = GameObject.Find("Tower");
    }

    private void Update()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;

        // 프레임 당 일정한 속도로 타겟을 향해 이동
        transform.position += direction * speed * Time.deltaTime;
    }
}
