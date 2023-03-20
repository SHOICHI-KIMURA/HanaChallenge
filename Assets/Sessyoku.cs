using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sessyoku : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Finger")
        {
            Debug.Log("SphereとCubeが接触しました");
            // パーティクルの再生などの処理を記述する
        }
    }
}