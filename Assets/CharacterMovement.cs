using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [Header("Movement")]
    [Tooltip("Horizontal Speed")]
    [SerializeField] private float moveSpeed;
    [Tooltip("Rate of change for moveSpeed")]
    [SerializeField] private float acceleration;
    [Tooltip("Deceleration")]
    [SerializeField] private float Deceleration;

    private float initialY;
    private float currentSpeed;
    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        initialY = transform.position.y;
    }
    
    public void Move(Vector3 inputVector)
    {

        if (inputVector == Vector3.zero)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= Deceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, 0);
            }
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, moveSpeed, Time.deltaTime * acceleration);
        }

        Vector3 movement = inputVector.normalized * currentSpeed * Time.deltaTime;
        characterController.Move(movement);
        transform.position = new Vector3(transform.position.x, initialY, transform.position.z);
    }
}
