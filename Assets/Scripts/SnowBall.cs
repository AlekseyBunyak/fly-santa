using UnityEngine;

public class SnowBall : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _damage;
    [SerializeField] private ParticleSystem _effect;
    
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(_effect, transform.position, Quaternion.identity);

            collision.GetComponent<PlayerController>().Health -= _damage;
            Destroy(gameObject);
        }
    }
}
