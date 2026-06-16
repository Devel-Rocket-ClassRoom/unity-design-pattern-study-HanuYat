using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StatePattern
{
    /// <summary>
    /// Handles player input and provides the input vector to the player controller.
    /// </summary>
    public class PlayerInput : MonoBehaviour
    {
        // Uses old Input class
        [Header("Controls")]
        [SerializeField] private KeyCode forward = KeyCode.W;
        [SerializeField] private KeyCode back = KeyCode.S;
        [SerializeField] private KeyCode left = KeyCode.A;
        [SerializeField] private KeyCode right = KeyCode.D;
        [SerializeField] private KeyCode jump = KeyCode.Space;
        [SerializeField] private KeyCode sprint = KeyCode.LeftShift;

        public Vector3 InputVector => inputVector;
        public bool IsJumping { get => isJumping; set => isJumping = value; }
        public bool IsSprinting { get => isSprinting; set => isSprinting = value; }

        private Vector3 inputVector;
        private bool isJumping;
        private bool isSprinting;
        private float xInput;
        private float zInput;
        private float yInput;

        public void HandleInput()
        {
            // Reset input
            xInput = 0;
            yInput = 0;
            zInput = 0;

            if (Input.GetKey(forward))
            {
                zInput++;
            }

            if (Input.GetKey(back))
            {
                zInput--;
            }

            if (Input.GetKey(left))
            {
                xInput--;
            }

            if (Input.GetKey(right))
            {
                xInput++;
            }

            inputVector = new Vector3(xInput, yInput, zInput);

            isJumping = Input.GetKeyDown(jump);
            isSprinting = Input.GetKey(sprint);
        }

        private void Update()
        {
            HandleInput();
        }
    }
}
