using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Player.Enable();
    }

    public Vector2 GetMoveInput()
    {
        Vector2 moveInput = playerInput.Player.Move.ReadValue<Vector2>();
        return moveInput;
    }
}
