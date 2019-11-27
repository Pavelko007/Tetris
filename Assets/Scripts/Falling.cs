using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float fallingSpeed = 1f;
    private float fallingTime = 0f;

    void Start()
    {
        
    }

    

    private void FixedUpdate()
    {
        fallingTime += Time.deltaTime;
        if (fallingTime > 1 / fallingSpeed)
        {
            fallingTime = 0;
            StepDown();
        }
    }

    private void StepDown()
    {
        transform.Translate(Vector3.down);
    }
}
