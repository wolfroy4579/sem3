using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheare_Controller : MonoBehaviour
{
    [SerializeField] float speed = 12.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal,0,Vertical);

        rb.AddForce(movement*speed);
    }
}
