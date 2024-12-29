using UnityEngine;

public class BulletTracking : MonoBehaviour
{

    public Transform player;
    public CharacterController cc;
    private float bulletSpeed = 10f;
    private Rigidbody rb;
    private AudioSource audioSource1;
    public AudioClip block;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        audioSource1 = GameObject.FindGameObjectWithTag("End").GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.LookAt(player);
        Vector3 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = direction * bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Shield"))
        {
            audioSource1.PlayOneShot(block);
            Debug.Log("Play sound");
            Destroy(gameObject);
        }
    }

}
