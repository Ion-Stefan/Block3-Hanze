using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    [SerializeField] private float rotationSpeed = 5f;
    PhotonView view;
    public float moveSpeed = 5f; // adjust this to change movement speed

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));


            }
            if (Input.GetMouseButton(0))
            {
                touchStart = true;
                pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            }
            else
            {
                touchStart = false;
            }



        }
    }

    private void FixedUpdate()
    {
        if (view.IsMine)
        {
            if (touchStart)
            {
                Vector2 offset = pointB - pointA;
                Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
                movePlayer(direction * -1);
            }

        }
    }

    private void movePlayer(Vector2 direction)
    {
        // Get horizontal and vertical input


        // Calculate movement direction
        Vector3 movement = new Vector3(direction.x, 0f, direction.y).normalized;

        // Apply movement
        transform.position += movement * moveSpeed * Time.deltaTime;

        Quaternion toRotation = Quaternion.LookRotation(-movement, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
    }
}
