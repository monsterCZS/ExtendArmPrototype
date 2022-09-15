using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;

    Vector2 moveVector = Vector2.zero;

    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Awake()
    {
        this.controls = new PlayerControls();

        this.controls.PlayerMap.Move.performed += context => this.moveVector = context.ReadValue<Vector2>();
        this.controls.PlayerMap.Move.canceled += context => this.moveVector = Vector2.zero;            
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(this.moveVector * this.moveSpeed * Time.deltaTime);
    }

    private void OnEnable()
    {
        this.controls.PlayerMap.Enable();
    }
}
