using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float speed = 12.0f;
    private float turnSpeed = 65.0f;
    private float horizontalInput;
    private float verticalInput;

    void Start() {

    }

    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}




//public class PlayerController : MonoBehaviour {
//    //Rigidbody m_Rigidbody;
//    //public int speed = 5;
//    //public float m_Speed = 5f;
//    // Start is called before the first frame update
//    void Start() {
//        //m_Rigidbody = GetComponent<Rigidbody>();
//    }

//    // Update is called once per frame
//    void Update() {
//        // 60 razy na 1s 
//        //move code
//        //transform.Translate(0, 0, 1);
//        transform.Translate(Vector3.forward * Time.deltaTime * 20);

//        //Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

//        //float horizontal = Input.GetAxis("Horizontal");
//        //float vertical = Input.GetAxis("Vertical");

//        //Vector3 move = new Vector3(horizontal, 0, vertical);
//        //m_Rigidbody.MovePosition(transform.position + move  * Time.deltaTime * speed);
//    }
//}
