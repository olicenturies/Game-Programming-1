using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("end"))
        {
            Debug.Log("Congratulations! You won!");
        }
    }

}
