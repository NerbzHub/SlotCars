using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float fSpeed = 0f;

    private Rigidbody rbVehicle = null;

    // Start is called before the first frame update
    void Start()
    {
        rbVehicle = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            InputFunc();
        }
    }

    void InputFunc()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rbVehicle.AddForce(gameObject.transform.forward * fSpeed);
        }
    }
}
