using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        characterController.Move(move * Time.deltaTime * speed);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (move != Vector3.zero)
        {
            float angle = Mathf.Atan2(move.y, move.x) * Mathf.Rad2Deg;

            // Saða doðru hareket ediyorsa
            if (horizontalInput > 0.0f)
            {
                angle -= 90.0f;
            }
            // Sola doðru hareket ediyorsa
            else if (horizontalInput < 0.0f)
            {
                angle += 270.0f;
            }
            // Yukarý doðru hareket ediyorsa
            else if (verticalInput > 0.0f)
            {
                angle = 0.0f;
            }
            // Aþaðý doðru hareket ediyorsa
            else if (verticalInput < 0.0f)
            {
                angle = 180.0f;
            }

            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        }
    }
}
