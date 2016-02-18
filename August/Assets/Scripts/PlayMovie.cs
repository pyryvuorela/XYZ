using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PlayMovie : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }
}


