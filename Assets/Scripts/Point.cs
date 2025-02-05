using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject _snowBall;
    [SerializeField] private GameObject _variant;

    private void Start()
    {
        Instantiate(_snowBall, transform.position, Quaternion.identity);
    }

}
