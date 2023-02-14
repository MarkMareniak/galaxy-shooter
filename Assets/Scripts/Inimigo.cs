using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Vector3.down * Time.deltaTime);
        LimiteInimigo();
    }
    private void LimiteInimigo()
    {
        if (transform.position.y < -7.25479f)
        {
            var newPos = transform.position;
            newPos.y = 5.25479f;
            newPos.x = Random.Range(-4, 8);
            transform.position = newPos;
        }
    }
}