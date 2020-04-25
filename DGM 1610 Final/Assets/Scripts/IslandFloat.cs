using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandFloat : MonoBehaviour
{
    public float amplitude = 0.7f;
    public float frequency = 1f;

    // position storage for movement
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();


    // Start is called before the first frame update
    void Start()
    {
        // This will mark and record the starting position and rotation of the pickup for use in later variables
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // This makes it float up and down using a Sin() algorithm
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}