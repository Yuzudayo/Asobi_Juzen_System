using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //?��v?��?��?��C?��?��?��[?��̈ړ�?��̑�?��?��
    public float speed = 12f;
    Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody?��ɃA?��N?��Z?��X?��?��?��ĕϐ�?��ɕێ�
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //?��?��?��E?��̃L?��[?��?��?��͂ɂ�葬?��x?��?��ύX?��?��?��?��
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
