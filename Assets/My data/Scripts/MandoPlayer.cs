using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MandoPlayer : MonoBehaviour
{
    public float velocidad = 3.5f;
    private float gravedad = 10f;
    private CharacterController mando;
    // Start is called before the first frame update
    void Start()
    {
        mando = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }
    void movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(horizontal, 0, vertical);
        Vector3 aceleracion = direccion * velocidad;
        aceleracion = Camera.main.transform.TransformDirection(aceleracion);
        aceleracion.y -= gravedad;
        mando.Move(aceleracion * Time.deltaTime);
    }
}
