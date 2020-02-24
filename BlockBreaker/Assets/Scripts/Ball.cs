using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] Paddle paddle;
    [SerializeField] float BallLaunchXVelocity = 2f;
    [SerializeField] float BallLaunchYVelocity = 15f;

    Vector2 paddleToBallVector;

    bool isLaunched = false;

    void Start() {
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    void Update() {
        if (!isLaunched) {
            LockBallToPaddle();
        }
        if (Input.GetMouseButtonDown(0) && !isLaunched) {
            LaunchBall();
        }
    }

    private void LockBallToPaddle() {
        Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePosition + paddleToBallVector;
    }

    private void LaunchBall() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(BallLaunchXVelocity, BallLaunchYVelocity);
        isLaunched = true;
    }
}
