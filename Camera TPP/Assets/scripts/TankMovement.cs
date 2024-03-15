using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horiInput;
    public float vertiInput;
    int speed = 40;


    private void Update()
    {
        horiInput = Input.GetAxis("Horizontal");
        vertiInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertiInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horiInput);

    }
}
