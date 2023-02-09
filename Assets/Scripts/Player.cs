using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");
        transform.Translate(moveX * speed * Vector3.right * Time.deltaTime);
        transform.Translate(moveY * speed * Vector3.up * Time.deltaTime);

        if (transform.position.x > 7.013509f)
        {
            var newPos = transform.position;
            newPos.x = 7.013509f;
            transform.position = newPos;
        }

        if (transform.position.x < -7.03098f)
        {
            var newPos = transform.position;
            newPos.x = -7.03098f;
            transform.position = newPos;
        }

        if (transform.position.y > 3.753351f)
        {
            var newPos = transform.position;
            newPos.y = 3.753351f;
            transform.position = newPos;
        }

        if (transform.position.y < -3.72366f)
        {
            var newPos = transform.position;
            newPos.y = -3.743805f;
            transform.position = newPos;
        }
    }
}