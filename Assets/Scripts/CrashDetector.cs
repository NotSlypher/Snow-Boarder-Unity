using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Invoke("reloadScene", 0.25f);
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
