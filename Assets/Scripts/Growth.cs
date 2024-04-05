using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Vector3 _scaleChange = new Vector3(_speed, _speed, _speed);
        transform.localScale += _scaleChange * Time.deltaTime;
    }
}
