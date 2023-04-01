using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Invoke("LoadResultScene", 5f);
        }
    }

    void LoadResultScene()
    {
        SceneManager.LoadScene("ResultScene"); //ここにシーン遷移のコードを追加する
    }
}
