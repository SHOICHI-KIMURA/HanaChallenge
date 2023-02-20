using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerUp : MonoBehaviour
{
    public float distance = 2f;
    public float speed = 2f;
    public float movementAmount = 5f;

    private float startPos;
    private float endPos;
    private float currentLerpTime;

    void Start()
    {
        startPos = transform.position.x - distance / 2;
        endPos = transform.position.x + distance / 2;
        currentLerpTime = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + movementAmount, transform.position.z);
        }



        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > speed)
        {
            float temp = endPos;
            endPos = startPos;
            startPos = temp;
            currentLerpTime = 0f;
        }

        float perc = currentLerpTime / speed;
        transform.position = new Vector3(Mathf.Lerp(startPos, endPos, perc), transform.position.y, transform.position.z);
    }
}
