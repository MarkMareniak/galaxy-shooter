using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject tiro;
    public Transform offsetTiro;
    private float nextFire = 0.0f;
    public float fireRate = 0.25f;
    public int tirosPorRajada = 3;
    private float proximaRajada = 0;
    public float intervalaRajadas = 0.5f;
    private int totalTiros = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        LimiteDeTela();

        if (Input.GetKey(KeyCode.Mouse0))
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
        if (transform.position.x > 7.945952f)
        {
            var newPos = transform.position;
            newPos.x = 7.945952f;
            transform.position = newPos;
        }

        if (transform.position.x < -7.936475f)
        {
            var newPos = transform.position;
            newPos.x = -7.936475f;
            transform.position = newPos;
        }

        if (transform.position.y > 4.261462f)
        {
            var newPos = transform.position;
            newPos.y = 4.261462f;
            transform.position = newPos;
        }

        if (transform.position.y < -4.25479f)
        {
            var newPos = transform.position;
            newPos.y = -4.25479f;
            transform.position = newPos;
        }
    }
    private void Atirar()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire && Time.time > proximaRajada)
        {
            nextFire = Time.time + fireRate;
            Instantiate(tiro, offsetTiro.position, Quaternion.identity);



            totalTiros = totalTiros + 1; //totalTiros++



            if (totalTiros == tirosPorRajada)
            {
                proximaRajada = Time.time + intervalaRajadas;
                totalTiros = 0;
            }
        }
    }
}