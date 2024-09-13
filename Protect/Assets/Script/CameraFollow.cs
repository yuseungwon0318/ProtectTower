using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform
    public Vector3 offset; // ī�޶�� �÷��̾� ���� �Ÿ� (������)
    public float smoothSpeed = 0.125f; // ī�޶� �������� �ε巯�� ����

    void LateUpdate()
    {
        // ��ǥ ��ġ ��� (�÷��̾� ��ġ + ������)
        Vector3 desiredPosition = player.position + offset;

        // �ε巴�� �̵��ϵ��� ���� ó��
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // ī�޶� ��ġ�� ����
        transform.position = smoothedPosition;
    }
}
