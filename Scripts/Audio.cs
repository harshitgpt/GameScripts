using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource mainTheme;

        private void Start()
    {
        mainTheme.Play();
    }


}


