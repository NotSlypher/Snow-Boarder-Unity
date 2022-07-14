using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem dustEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
            dustEffect.Play();
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
            dustEffect.Stop();
    }
}
