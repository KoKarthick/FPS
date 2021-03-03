using UnityEngine;

public class Lookround : MonoBehaviour {
    [SerializeField] float lookSensitivtyX;
    [SerializeField] float lookSensitivtyY;
    float Xrot;
    CharacterController cc;
    MovementController movementController;
    float speedX, speedY;
    void Start() {
        cc = GetComponentInParent<CharacterController>();
        movementController = GetComponentInParent<MovementController>();
    }

    // Update is called once per frame
    void Update() {
        cc.transform.Rotate(Vector3.up * speedX * Time.deltaTime);
        Xrot -= speedY;
        Xrot = Mathf.Clamp(Xrot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(Xrot, 0, 0);

    }
    public void ReceiveLookinput(Vector2 look) {
        speedX = look.x * lookSensitivtyX;
        speedY = look.y * lookSensitivtyY;
    }
}
