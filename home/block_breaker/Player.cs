using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //?申v?申?申?申C?申?申?申[?申����鐃�?申��鐃�?申?申
    public float speed = 12f;
    Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody?申��A?申N?申Z?申X?申?申?申����鐃�?申����鐃�
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //?申?申?申E?申��L?申[?申?申?申����鐃処��?申x?申?申��X?申?申?申?申
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
