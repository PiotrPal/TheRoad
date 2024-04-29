using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour {
    public float horizontalInput;
    public float speed = 20.0f;
    public int boudary = 23;

    public GameObject projectilePrefab;

    void Start() {

    }

    void Update() {
        if (transform.position.x < -boudary) {
            transform.position = new Vector3(-boudary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boudary) {
            transform.position = new Vector3(boudary, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
