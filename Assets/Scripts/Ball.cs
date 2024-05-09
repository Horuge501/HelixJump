using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float jumpSpeed;
    [SerializeField] private GameObject splash;
    [SerializeField] private MeshRenderer ball;
    public GameObject objectRotator;
    private Rotator rotator;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ball = GetComponent<MeshRenderer>();
        rotator = objectRotator.GetComponent<Rotator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            splash.SetActive(true);
            ball.enabled = false;
            rotator.enabled = false;
            Invoke("ReloadScene", 5f);
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("HelixJump");
    }
}