﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateArm2 : MonoBehaviour
{
    public float force = 0.5f;
    public int Player;

    private void FixedUpdate()
    {
        if (Player == 1)
        {
            transform.GetComponentInChildren<Rigidbody2D>().AddForce(new Vector2(-Input.GetAxisRaw("Axis 11 Player 1"), 0f), ForceMode2D.Impulse);
            transform.GetComponentInChildren<Rigidbody2D>().AddForce(new Vector2(0f, -Input.GetAxisRaw("Axis 12 Player 1")), ForceMode2D.Impulse);


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.left * force, ForceMode2D.Impulse);

            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.right * force, ForceMode2D.Impulse);

            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.down * force, ForceMode2D.Impulse);

            }
        }
        else
        {
            transform.GetComponentInChildren<Rigidbody2D>().AddForce(new Vector2(Input.GetAxisRaw("Axis 11 Player 2") * 2f, 0f), ForceMode2D.Impulse);
            transform.GetComponentInChildren<Rigidbody2D>().AddForce(new Vector2(0f, -Input.GetAxisRaw("Axis 12 Player 2") * 2f), ForceMode2D.Impulse);

            if (Input.GetKey(KeyCode.A))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.left * force, ForceMode2D.Impulse);

            }

            if (Input.GetKey(KeyCode.D))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.right * force, ForceMode2D.Impulse);

            }

            if (Input.GetKey(KeyCode.W))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);

            }
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(Vector2.down * force, ForceMode2D.Impulse);

            }
        }



    }
}
