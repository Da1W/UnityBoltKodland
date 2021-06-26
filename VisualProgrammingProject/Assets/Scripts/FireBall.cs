using UnityEngine;
using Bolt;

public class FireBall : MonoBehaviour
{
    float speed = 5;
    private Vector3 direction;

    public void setDirection(Vector3 dir)
    {
        direction = dir;
    }

    private void Start()
    {
        setDirection(transform.forward);
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        speed += 0.1f;
    }
}
