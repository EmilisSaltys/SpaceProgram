using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour {

    public Text tekstas;

    public float score;



    public static Scoring instance;

    void Awake()
    {
        instance = this;
    }



    void Start()
    {



    }


    void Update()
    {

if (score == 15)
        {
            SceneManager.LoadScene(2);
        }


    }
}
