using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play1 : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Veikia");
    }



}
