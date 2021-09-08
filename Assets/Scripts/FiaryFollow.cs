using UnityEngine;

public class FiaryFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float maxSpeed;

    private Vector3 speed;

    void Update()
    {
        speed += (target.position + offset - transform.position) * Time.deltaTime;
        speed = Vector3.ClampMagnitude(speed, maxSpeed);
        transform.position += speed * Time.deltaTime;
    }
}
