using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("reloadScene", 0.25f);
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
