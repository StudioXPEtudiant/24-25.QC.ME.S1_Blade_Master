using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieAttsck : MonoBehaviour
{
    [SerializeField] private int quantiteDegat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Attack)
    {
        if (Attack.tag == "Player");
        {
            Debug.Log(Attack.name + " " + Attack.tag);
            if(Attack.GetComponent<SystemeDeVieAvecImage>() != null)
                Attack.GetComponent<SystemeDeVieAvecImage>().InfligerDommage(quantiteDegat);
        }
    }
}
