using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tower : MonoBehaviour
{
    public float attackSpd;
    public float attackPower;

    private float time = 0;
    public float radius = 0f;
    public LayerMask layer;
    public Collider[] colliders;
    public Collider short_enemy;

    public GameObject bulletPre;

    void Update()
    {
        time += Time.deltaTime;

        if (time > attackSpd)
        {
            if(short_enemy != null)
                Attack();
            time = 0;
        }

        colliders = Physics.OverlapSphere(transform.position, radius, layer);

        if (colliders.Length > 0)
        {
            float short_distance = Vector3.Distance(transform.position, colliders[0].transform.position);
            foreach (Collider col in colliders)
            {
                float short_distance2 = Vector3.Distance(transform.position, col.transform.position);
                if (short_distance > short_distance2)
                {
                    short_distance = short_distance2;
                    short_enemy = col;  
                }
            }

            if(short_enemy == null)
            {
                short_enemy = colliders[0];
            }

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public void Attack()
    {
        GameObject bullet = Instantiate(bulletPre,transform.position, Quaternion.identity);

        Vector3 direction = (short_enemy.transform.position - transform.position).normalized;

        bullet.transform.forward = direction;
    }
}
