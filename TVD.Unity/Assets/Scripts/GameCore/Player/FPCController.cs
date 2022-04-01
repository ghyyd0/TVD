using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCController : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public GameObject _camera;
    [Range(0, 360)] public float _zAngleRestriction;
    [Range(-100, 100)] public float _clampedZAngle = 0;
    float speed = 5;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _zAngleRestriction = 45;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 verticalValue = transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontalValue = transform.right * Input.GetAxis("Horizontal");
        Vector3 totalValue = horizontalValue + verticalValue;
        characterController.SimpleMove(totalValue * 5);
        float turnSpeed = 5.0f;
        float rotateValue = Input.GetAxis("Mouse X") * turnSpeed;
        float rotateZValue = Input.GetAxis("Mouse Y");
        transform.Rotate(0, rotateValue, 0);

        _clampedZAngle -= rotateZValue;
        _clampedZAngle = Mathf.Clamp(_clampedZAngle, -_zAngleRestriction, _zAngleRestriction);
        _camera.transform.eulerAngles = new Vector3 (_clampedZAngle, transform.localEulerAngles.y, 0);
    }
}
