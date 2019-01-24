using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    private Transform cameraPoint;
    [SerializeField]
    private Transform cameraPosition;
    [SerializeField]
    private float movementSpeed = 10f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.LookAt(cameraPoint);
        Move();
	}

    private void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if (Mathf.Abs(hor) > 0)
        {
            cameraPoint.Translate(Vector3.right * hor * movementSpeed * Time.deltaTime);
        }
        if (Mathf.Abs(ver) > 0)
        {
            cameraPoint.Translate(Vector3.forward * ver * movementSpeed * Time.deltaTime);
        }

        /* Управление камеры мышью отключено
        if (Input.mousePosition.x >= Screen.width-10)
        {
            cameraPoint.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        if (Input.mousePosition.x <= 10)
        {
            cameraPoint.Translate(Vector3.right * -movementSpeed * Time.deltaTime);
        }
        if (Input.mousePosition.y >= Screen.height - 10)
        {
            cameraPoint.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.mousePosition.y <= 10)
        {
            cameraPoint.Translate(Vector3.forward * -movementSpeed * Time.deltaTime);
        }
        */

        transform.position = cameraPosition.position;
    }
}
