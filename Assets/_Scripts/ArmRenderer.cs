using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRenderer : MonoBehaviour
{
    private LineRenderer arm;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject hand;
    
    // Start is called before the first frame update
    void Start()
    {
        this.arm = GetComponent<LineRenderer>();
        this.arm.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        this.arm.SetPosition(0, this.player.transform.position);
        this.arm.SetPosition(1, this.hand.transform.position);
    }
}
