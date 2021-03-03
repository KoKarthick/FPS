using UnityEngine;

public class MovementController : MonoBehaviour {
    [SerializeField] float speed;

    [SerializeField] float gravity = -30f;//-9.81;
    Vector3 velocityDown;

    [SerializeField] Transform groundCheckObj;
    [SerializeField] LayerMask groundLayer;

    CharacterController cc;
    Lookround lookround;
    PlayerInput inputs;
    PlayerInput.GroundMoveActions groundMove;

    Vector2 horizontalInput;
    Vector2 lookinput;


    void Awake() {
        inputs = new PlayerInput();
        groundMove = inputs.groundMove;
        cc = GetComponent<CharacterController>();
        lookround = GetComponentInChildren<Lookround>();
    }
    private void Start() {
        groundMove.move.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        groundMove.mouseX.performed += ctx => lookinput.x = ctx.ReadValue<float>();
        groundMove.mouseY.performed += ctx => lookinput.y = ctx.ReadValue<float>();

    }
    private void OnEnable() {
        inputs.Enable();
    }
    private void OnDisable() {
        inputs.Disable();
    }
    // Update is called once per frame
    void Update() {

        Vector3 move = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y);
        cc.Move(move * speed * Time.deltaTime);

        velocityDown.y += gravity * Time.deltaTime;
        cc.Move(velocityDown * Time.deltaTime);

        LookInputUpdate();
    }

    void LookInputUpdate() {
        lookround.ReceiveLookinput(lookinput);
    }
}
