using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevelPoint : MonoBehaviour
{
    public string LevelName;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(LevelName);
            //Invoke("Falling", fallingTime);
        }
    }
}
