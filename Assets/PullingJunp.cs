using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJunp : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Physics.gravity = new Vector3(0.0f, -12.0f, 0.0f);
            Vector3 dist = clickPosition - Input.mousePosition;

            if(dist.sqrMagnitude == 0) { return; }

            rb.velocity = dist.normalized * jumpPower;
        }
    }
}
