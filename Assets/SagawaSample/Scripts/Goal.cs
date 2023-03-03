using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject _particle;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Finger")
        {
            Debug.Log("�S�[�����܂����I");
            _particle.SetActive(true);
        }
    }
}
