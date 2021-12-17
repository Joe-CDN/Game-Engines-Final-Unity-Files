using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Rigidbody rb;

    float move;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().useGravity = false;
        rb.velocity = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Respawn"))
        {
            Destroy(this.transform.gameObject);
        }
    }

    void OnMouseEnter () 
    {
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            Destroy(this.transform.gameObject); 
            PersistanceManager.Instance.score += 100;
        }
    }
}
