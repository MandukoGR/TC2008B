using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //velocidad del vehículo
    public float speed = 5.0f;
    //velocidad de giro
    public float turnSpeed = 0.0f;

    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      //Mover vehiculo hacia adelante
      //transform.Translate(0,0,1);
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       //Modificar el giro
      // transform.Translate(Vector3.right * Time.deltaTime* turnSpeed * horizontalInput);
      transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
