using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] Pa FinishLine;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("reloadScene",0.75f);
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}