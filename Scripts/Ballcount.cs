using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ballcount : MonoBehaviour
{
    InsantiateandThrowball ballleft;
      TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        ballleft = FindObjectOfType<InsantiateandThrowball>();
    }


    private void Update()
    {
        text.text =      ballleft.BallsLeft().ToString();


    }

    



}
