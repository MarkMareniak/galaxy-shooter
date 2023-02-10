using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject tiro;
    public Transform offsetTiro;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        LimiteDeTela();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

        Atirar();

        }
    }

    private void Movimentacao()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");
        transform.Translate(moveX * speed * Vector3.right * Time.deltaTime);
        transform.Translate(moveY * speed * Vector3.up * Time.deltaTime);
    }

    private void LimiteDeTela()
    {
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

        if (transform.position.y > 4.282274f)
        {
            var newPos = transform.position;
            newPos.y = 4.282274f;
            transform.position = newPos;
        }

        if (transform.position.y < -3.72366f)
        {
            var newPos = transform.position;
            newPos.y = -3.72366f;
            transform.position = newPos;
        }
    }
    private void Atirar()
    {
        Instantiate(tiro, offsetTiro.position, Quaternion.identity);
    }
}