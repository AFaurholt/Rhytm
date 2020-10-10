using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform = default;
    [SerializeField] private Transform _currentStage = default;
    [SerializeField] private float _stageSpeed = 1f;
    [SerializeField] private float _stageDurationSec = 10f;

    private Vector2 _initPos = Vector2.zero;
    private void Start()
    {
        _initPos = _playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector2 = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 movPos = _initPos;
        if (inputVector2.x == 1)
        {
            movPos.x += 5;
        }
        if (inputVector2.y == 1)
        {
            movPos.y += 5;
        }

        _playerTransform.position = movPos;

        if (_stageDurationSec > 0)
        {
            _currentStage.Translate((-_stageSpeed * Time.deltaTime), 0f, 0f);
            _stageDurationSec -= Time.deltaTime;
        }
    }
}
