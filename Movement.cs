using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    private CharacterController controller;
    private float moveSpeed = 5;
    private float rotationSpeed = 100;
    private float turnDirection;
    private float turnY;
    private bool isTurning;

    public TextMeshProUGUI livesText;

    private bool fail;
    private float lives = 3;
    public Transform spawn;

    private bool isHit = false;

    public AudioSource audioSource1;
    public AudioClip shot;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(transform.forward * moveSpeed * Time.deltaTime);

        if(isTurning)
        {
            Turn();
        }

        livesText.text = "Lives:" + lives;

        if (lives < 1)
        {
            lives = 3;
            controller.enabled = false;
            transform.position = spawn.position;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            controller.enabled = true;

            isTurning = false;
            turnY = transform.eulerAngles.y;
            return;
        }

        if(isTurning)
        {
            Turn();
        }

    }

    void Turn()
    {

        Quaternion turnTo = Quaternion.Euler(transform.eulerAngles.x, turnY, transform.eulerAngles.z);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, turnTo, rotationSpeed * Time.deltaTime);

        if (Quaternion.Angle(transform.rotation, turnTo) < .1f)
        {
            transform.rotation = turnTo;
            isTurning = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TurnLeft"))
        {
            turnDirection = -90;
            turnY = transform.eulerAngles.y + turnDirection;
            isTurning = true;
        }
        else if(other.CompareTag("TurnRight"))
        {
            turnDirection = 90;
            turnY = transform.eulerAngles.y + turnDirection;
            isTurning = true;
        }

        if (other.CompareTag("bullet") && !isHit)
        {
            isHit = true;
            lives -= 1;
            audioSource1.PlayOneShot(shot);
            Destroy(other.gameObject);

            Invoke(nameof(ResetHit), 0.1f);
        }

        if (other.CompareTag("End"))
        {
            LoadScene("MainMenu");
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void ResetHit()
    {
        isHit = false;
    }

}
