using UnityEngine;

public class ShieldRotation : MonoBehaviour
{
    private Transform player;
    private Transform shield;
    private float distanceFromPlayer = 1f;

    void Start()
    {
        player = transform;
        shield = transform.Find("Shield");
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 directionToMouse = hit.point - player.position;

            float angle = Mathf.Atan2(directionToMouse.x, directionToMouse.z) * Mathf.Rad2Deg;

            shield.rotation = Quaternion.Euler(0, angle, 0);

            shield.position = player.position + shield.forward * distanceFromPlayer;
        }
    }
}
