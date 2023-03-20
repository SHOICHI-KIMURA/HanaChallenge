using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoseGoal : MonoBehaviour
{
    [SerializeField]
    private GameObject _particle;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Finger")
        {
            Debug.Log("ゴールしました");
            _particle.SetActive(true);
        }
    }
}
