using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    // Offset para posicionar camara en las coordenadas que queremos
    private Vector3 offset = new Vector3(0,6,-7);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
      // Se posiciona en la posición del vehículo y se le agrega el offset
      transform.position = player.transform.position + offset;
    }
}
