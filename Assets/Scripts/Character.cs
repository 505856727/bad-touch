using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField]
    private float movespeed;
    private void FixedUpdate()
    {
        CharacterMove();
    }
    void CharacterMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, movespeed, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
