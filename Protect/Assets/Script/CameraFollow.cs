using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform
    public Vector3 offset; // 카메라와 플레이어 간의 거리 (오프셋)
    public float smoothSpeed = 0.125f; // 카메라 움직임의 부드러움 정도

    void LateUpdate()
    {
        // 목표 위치 계산 (플레이어 위치 + 오프셋)
        Vector3 desiredPosition = player.position + offset;

        // 부드럽게 이동하도록 보간 처리
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 카메라 위치를 설정
        transform.position = smoothedPosition;
    }
}
