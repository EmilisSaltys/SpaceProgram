using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulka : MonoBehaviour {

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

       

	}
	
	// Update is called once per frame
	void Update () {


        rb.velocity = new Vector2(0, 10);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("why wont you work ;_;");
        }

        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }
}
