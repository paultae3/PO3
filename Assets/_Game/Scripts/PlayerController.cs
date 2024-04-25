using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 12f;
    [SerializeField] float _turnSpeed = 3f;

    Rigidbody _rb = null;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        TurnPlayer();
    }

    void MovePlayer()
    {
        float moveAmountThisFrame = Input.GetAxisRaw("Vertical") * _moveSpeed;


        Vector3 moveDirection = transform.forward * moveAmountThisFrame;


        _rb.AddForce(moveDirection);

        _rb.drag = 2;

        _rb.angularDrag = 7;

    }

    void TurnPlayer()
    {

        float turnAmountThisFrame = Input.GetAxisRaw("Horizontal") * _turnSpeed;


        Quaternion turnOffset = Quaternion.Euler(0, turnAmountThisFrame, 0);


        _rb.MoveRotation(_rb.rotation * turnOffset);

    }
}

