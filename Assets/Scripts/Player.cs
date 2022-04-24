using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float runSpeed;

    private float initialSpeed;
    private Rigidbody2D rig;
    private Vector2 _direction;

    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    private void Start() 
    { 
        rig = GetComponent<Rigidbody2D>();
        initialSpeed = speed;
    }

    private void Update() 
    {
        OnInput();

        OnRun();
    }

    private void FixedUpdate() => OnMove();

    #region Movement
    void OnMove()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }

    void OnInput()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void OnRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = initialSpeed;
        }
    }
    #endregion
}
