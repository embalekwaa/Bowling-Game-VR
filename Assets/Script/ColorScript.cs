using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Renderer Pins;
    public GameObject Pin;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "BowlingBall")
        {
            Pins.material.color = Color.cyan;
        }
    }

}
