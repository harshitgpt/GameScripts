using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    int Count=0;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {

            Count++;
            

        }
    }

    public  int TotalCount()
    {
        return Count;

    }














}
