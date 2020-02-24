using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    [SerializeField] float screenWidthUnits = 16f;

    [SerializeField] float minPaddlePosition = 1f;

    [SerializeField] float maxPaddlePosition = 15f;

    void Update() {
        float mousePosition = (Input.mousePosition.x / Screen.width) * screenWidthUnits;
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
        paddlePosition.x = Mathf.Clamp(mousePosition, minPaddlePosition, maxPaddlePosition);
        transform.position = paddlePosition;
    }
}
