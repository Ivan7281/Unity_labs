using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralPlane : MonoBehaviour
{
    [SerializeField] private float _radius = 1f;
    [SerializeField] private float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = _radius * Mathf.Cos(Time.time * _speed);
        float z = _radius * Mathf.Sin(Time.time * _speed);
        transform.Translate(x, 0f, z);
    }
}
