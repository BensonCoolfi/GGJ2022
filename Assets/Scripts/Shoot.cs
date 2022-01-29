using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Gun;

    Vector2 direction;
    float lookAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        lookAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        // float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        Gun.rotation = Quaternion.Euler(0, 0, lookAngle);
    }
}
