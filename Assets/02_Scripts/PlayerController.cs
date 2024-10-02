using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionProperty moveAction; // Vector2 (x, y)
    [SerializeField] private InputActionProperty attackAction; // 버튼 bool

    private Vector2 moveInput;

    void OnEnable()
    {
        moveAction.action.performed += (ctx) =>
        {
            moveInput = ctx.ReadValue<Vector2>();
        };
        moveAction.action.canceled += (ctx) =>
        {
            moveInput = Vector2.zero;
        };
    }

    void Start()
    {

    }

    void Update()
    {
        Debug.Log($"x={moveInput.x} / y={moveInput.y}");
        //moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
