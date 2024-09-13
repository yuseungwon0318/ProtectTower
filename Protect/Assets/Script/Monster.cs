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

        // ������ �� ������ �ӵ��� Ÿ���� ���� �̵�
        transform.position += direction * speed * Time.deltaTime;
    }
}
