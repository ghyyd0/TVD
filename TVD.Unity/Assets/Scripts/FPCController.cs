using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCController : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public GameObject _camera;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 verticalValue = transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontalValue = transform.right * Input.GetAxis("Horizontal");
        Vector3 totalValue = horizontalValue + verticalValue;
        characterController.SimpleMove(totalValue);
        float turnSpeed = 5.0f;
        float rotateValue = Input.GetAxis("Mouse X") * turnSpeed;
        float rotatezValue = Input.GetAxis("Mouse Y");
        transform.Rotate(0, rotateValue, 0);
        _camera.transform.Rotate(rotatezValue, 0, 0);
    }
}
