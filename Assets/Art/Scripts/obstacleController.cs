using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacleController : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<fishController>()!=null)
        {
            SceneManager.LoadScene(0);
            Debug.Log("Load");
        }
    }
}
