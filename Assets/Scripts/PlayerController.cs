using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    ///Controller
    private CharacterController controller;
    ///Velocity
    private Vector3 playerVelocity;
    ///<summary>Player Speed</velocity>
    public float playerSpeed = 10.0f;

    ///Start
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    ///Update
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        controller.Move(playerVelocity * Time.deltaTime);
    }
}
