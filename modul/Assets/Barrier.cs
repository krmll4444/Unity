using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationAmount = 90f; 
    private float timer = 0f;
    public float rotationInterval = 1f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= rotationInterval)
        {
            transform.Rotate(0f, 0f, rotationAmount);
            timer = 0f;
        }
    }
}
