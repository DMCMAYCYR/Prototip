using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterManager : MonoBehaviour
{
    
    float speed = 2;
    Rigidbody rb;
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += Vector3.forward * 10*Time.deltaTime;
        float translation = Input.GetAxis("Horizontal")*speed;
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                transform.position += Vector3.right * 10 * Time.deltaTime;
                Debug.Log("Sağ");

            }
            else
            {
                transform.position += -Vector3.right * 10 * Time.deltaTime;
                Debug.Log("Sol");
            }
        }
        rb.velocity = new Vector3(translation * speed, 0, 0);
    }
}
