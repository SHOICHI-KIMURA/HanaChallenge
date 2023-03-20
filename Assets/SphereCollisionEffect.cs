using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollisionEffect : MonoBehaviour
{
    public GameObject effectPrefab; // エフェクト
    private float collisionTime; // 接触している時間

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            collisionTime = Time.time; // 接触した時間を記録
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            float duration = Time.time - collisionTime; // 接触している時間を計算
            if (duration > 0f)
            {
                Instantiate(effectPrefab, transform.position, Quaternion.identity); // エフェクトを再生
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            collisionTime = 0f; // 接触していない状態にリセット
        }
    }
}
