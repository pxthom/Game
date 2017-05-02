using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picked : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wrench"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("gear"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("piston"))
        {
            other.gameObject.SetActive(false);
        }
    }

}
