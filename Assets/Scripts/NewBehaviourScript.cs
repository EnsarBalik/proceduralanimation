using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Leg0Ball;
    public GameObject leg0;
    public GameObject Leg1Ball;
    public GameObject leg1;
    public GameObject Leg2Ball;
    public GameObject leg2;
    public GameObject Leg3Ball;
    public GameObject leg3;

    private Vector3 Leg0Vector;
    private Vector3 Leg1Vector;
    private Vector3 Leg2Vector;
    private Vector3 Leg3Vector;

    public float legSpeed;

    public bool moveAble;
    
    private void Start()
    {
        Leg0Vector = new Vector3(leg0.transform.position.x, leg0.transform.position.y, leg0.transform.position.z);
        Leg0Ball.transform.position = Leg0Vector;

        Leg1Vector = new Vector3(leg1.transform.position.x, leg1.transform.position.y, leg1.transform.position.z);
        Leg1Ball.transform.position = Leg1Vector;

        Leg2Vector = new Vector3(leg2.transform.position.x, leg2.transform.position.y, leg2.transform.position.z);
        Leg2Ball.transform.position = Leg2Vector;

        Leg3Vector = new Vector3(leg3.transform.position.x, leg3.transform.position.y, leg3.transform.position.z);
        Leg3Ball.transform.position = Leg3Vector;
    }

    private void Update()
    {
        var transformPos = transform.position;
        var legPos0 = leg0.transform.position;
        var legPos1 = leg1.transform.position;
        var legPos2 = leg2.transform.position;
        var legPos3 = leg3.transform.position;

        var testCalculate = new Vector3(0, 0, legPos0.z + transformPos.z);
        float distance = legPos0.z + transformPos.z;

        Leg0Vector = new Vector3(legPos0.x + transformPos.x, legPos0.y,
            testCalculate.z);
        Leg0Ball.transform.position = Leg0Vector;

        if (distance > 0.32f)
        {
            moveAble = true;
            leg0.transform.position = Vector3.Lerp(leg0.transform.position, Leg0Ball.transform.position,
                Time.deltaTime * legSpeed);
        }
        else
        {
            moveAble = false;
        }

        Leg1Vector = new Vector3(legPos1.x + transformPos.x, legPos1.y,
            legPos1.z + transformPos.z);
        Leg1Ball.transform.position = Leg1Vector;

        Leg2Vector = new Vector3(legPos2.x + transformPos.x, legPos2.y,
            legPos2.z + transformPos.z);
        Leg2Ball.transform.position = Leg2Vector;

        Leg3Vector = new Vector3(legPos3.x + transformPos.x, legPos3.y,
            legPos3.z + transformPos.z);
        Leg3Ball.transform.position = Leg3Vector;

        Debug.DrawLine(Leg0Ball.transform.position, legPos0, Color.green);
        Debug.DrawLine(Leg1Ball.transform.position, legPos1, Color.green);
        Debug.DrawLine(Leg2Ball.transform.position, legPos2, Color.green);
        Debug.DrawLine(Leg3Ball.transform.position, legPos3, Color.green);
    }
}