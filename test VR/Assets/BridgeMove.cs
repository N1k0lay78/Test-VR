using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMove : MonoBehaviour
{
    public float moveToX;
    public float moveToZ;

    private float heigth;

    public bool isMove;

    private Transform myTransfrom;
    // Start is called before the first frame update
    void Start()
    {
        myTransfrom = GetComponent<Transform>();
        heigth = myTransfrom.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            isMove = !isMove;
        }
        if (isMove)
        {
            myTransfrom.position = new Vector3(moveToX, heigth, moveToZ);
        }
        else
        {
            myTransfrom.position = new Vector3(19, heigth, 14);
        }
    }
}
