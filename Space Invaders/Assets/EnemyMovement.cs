using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour {

    public float speed;
        

	
	void Start () {

        
	}
	

	void Update()
    {

        transform.Translate(Vector2.right * speed);


        if(transform.position.x > 2)
        {
            speed = speed * -1;


        }

        if (transform.position.x < -2)
        {

            speed = speed * -1;

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        }

        if (transform.position.y <= -3.50)
        {
            Debug.Log("works");

            SceneManager.LoadScene(2);

        }

      





    }
}
