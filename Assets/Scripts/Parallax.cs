using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private float _andX;
    [SerializeField] private float _startX;

    private void Update()
    {        
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (transform.position.x <= _andX)
        {
            Vector2 position = new Vector2(_startX, transform.position.y);
            transform.position = position;
        }
    }
}
