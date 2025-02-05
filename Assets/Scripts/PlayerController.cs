using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private float _yincrement;
    [SerializeField] private float _speed;
    [SerializeField] private float _maxHeigt;
    [SerializeField] private float _minHeigt;

    [SerializeField] private Text _healthPanel;


    public float Health;

    private Vector2 _targetPos;
    private bool _isMoving;
    private float _vertInput;

    private AudioSource _audioSource;

    private void Start()
    {
        _targetPos = transform.position;
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        _vertInput = Input.GetAxis("Vertical");

        _healthPanel.text = $"Жизни: {Health}";        

        transform.position = Vector2.MoveTowards(transform.position, _targetPos, _speed * Time.deltaTime);

        if (!_isMoving) 
        {
            if (_vertInput > 0.2 && transform.position.y < _maxHeigt)
            {
                _audioSource.Play();
                _targetPos = new Vector2(transform.position.x, transform.position.y + _yincrement);
                _isMoving = true;
            }

            else if (_vertInput < -0.2 && transform.position.y > _minHeigt)
            {
                _audioSource.Play();
                _targetPos = new Vector2(transform.position.x, transform.position.y - _yincrement);
                _isMoving = true;
            }
        }
        
        if(transform.position.y == _targetPos.y)
            _isMoving = false;
    }

    private void FixedUpdate()
    {
        if(Health <= 0)
        {
            _gameManager.GameOver();
            _gameManager.PauseGame();
        }
    }

    public void GoUp()
    {
        if (!_isMoving)
        {
            if (transform.position.y < _maxHeigt)
            {
                _audioSource.Play();
                _targetPos = new Vector2(transform.position.x, transform.position.y + _yincrement);
                _isMoving = true;
            }            
        }
    }

    public void GoDown()
    {
        if (!_isMoving)
        {
            if (transform.position.y > _minHeigt)
            {
                _audioSource.Play();
                _targetPos = new Vector2(transform.position.x, transform.position.y - _yincrement);
                _isMoving = true;
            }
        }
    }
}
