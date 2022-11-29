using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class InsantiateandThrowball : MonoBehaviour
{
    GameObject projectile;
    public int throwLeft;
    Touch touch;

  [Header("References")]
    public Transform cam;
    public Transform spawnPoint;
    public GameObject objectToThrow;
    public AudioSource shotSound;
   
    

    [Header("Settings")]
    public int totalThrows;
    public float throwCoolDown;


    [Header("Throwing")]
    
    public float throwforce;
    public float throwupwardForce;

    bool readyToThrow;



    private void Awake()
    {

        throwLeft = 20;
    }



    void Start()
    {
       
        readyToThrow = true;
    }

   
    void Update()
    {
        if(Input.touchCount>0 && readyToThrow && totalThrows>0)
        {
                 touch = Input.GetTouch(0);
                 shotSound.Play();
                 Throw();
            

        }
    }

    private void Throw()
    {
        Vector3 mobileTouchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 12));

        readyToThrow = false;



        GameObject projectile = Instantiate(objectToThrow, spawnPoint.position, Quaternion.identity);

        Rigidbody ProjectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceDirection = cam.transform.forward;

        RaycastHit Hit;

        if (Physics.Raycast(mobileTouchPosition, cam.forward, out Hit, 40))
        {

            forceDirection = (Hit.point - spawnPoint.position);

        }

        Vector3 forceToAdd = forceDirection * throwforce + transform.up * throwupwardForce;

        ProjectileRb.AddForce(forceToAdd, ForceMode.Impulse);



        throwLeft = (totalThrows--) - 1;

        Invoke(nameof(ResetThrow), throwCoolDown);



   
    }


    private void ResetThrow()
    {
        readyToThrow = true;

    }

    private void Destroy()
    {
        Destroy(projectile);
    }

    
    public int BallsLeft()
    {
        return throwLeft;

    }

  


}
