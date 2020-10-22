using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float speedofSpin = 2.0f;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, speedofSpin * Time.deltaTime, Space.World);
    }
}
