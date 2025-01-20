using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    [Header("Controls")]
    [Tooltip("use Keys to move")]
    [SerializeField] private KeyCode forwardK = KeyCode.W;
    [SerializeField] private KeyCode backwardK = KeyCode.S;
    [SerializeField] private KeyCode rightK = KeyCode.D;
    [SerializeField] private KeyCode leftK = KeyCode.A;

    public Vector3 inputVector;
    private CharacterMovement charMove;

    private void Awake()
    {
        charMove = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        charMove.Move(inputVector);
        HandleInput();
    }

    public void HandleInput()
    {
        float xInput = 0;
        float zInput = 0;
        if (Input.GetKey(forwardK))
        {
            zInput++;
        }
        if (Input.GetKey(backwardK))
        {
            zInput--;
        }
        if (Input.GetKey(leftK))
        {
            xInput--;
        }
        if (Input.GetKey(rightK))
        {
            xInput++;
        }
        inputVector = new Vector3(xInput, 0, zInput);

    }

}
