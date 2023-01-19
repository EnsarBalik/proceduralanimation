using UnityEngine;
using UnityEngine.UI;

public class BottomPoint : MonoBehaviour
{
    Vector3 originalPosition;
    public GameObject moveBall;
    public float legMoveSpeed = 7f;
    public float moveDistance = 0.7f;
    public float moveStoppingDistance = 0.4f;
    public BottomPoint oppsiteLeg;
    bool isMoving = false;
    bool moving = false;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        float distanceToMoveCube = Vector3.Distance(transform.position, moveBall.transform.position);
        if((distanceToMoveCube >= moveDistance && !oppsiteLeg.isItMoving()) || moving)
        {
            moving = true;
            transform.position = Vector3.Lerp(transform.position, moveBall.transform.position, Time.deltaTime * legMoveSpeed);
            originalPosition = transform.position;
            isMoving = true;
            
            if(distanceToMoveCube < moveStoppingDistance)
            {
                moving = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, Time.deltaTime * legMoveSpeed * 3f);
            isMoving = false;
        }
    } 

    public bool isItMoving()
    {
        return isMoving;
    }
    
    
    // private Vector3 originalPos;
    //
    // public Transform mainObject;
    // public bool moveAble;
    // public float legSpeed;
    // public Transform ball;
    //
    // [Range(0, 1)] public float debugTime;
    //
    // private void Start()
    // {
    //     originalPos = transform.position;
    //
    //     ball.position = transform.position;
    // }
    //
    // private void Update()
    // {
    //     var transformPos = transform.position;
    //
    //     var testCalculate = new Vector3(0, 0, transformPos.z);
    //     float z = transformPos.z;
    //     float x = transformPos.x;
    //
    //     float distance = x + z;
    //
    //     // var ballPos = new Vector3(mainObject.position.x + transformPos.x, transformPos.y,
    //     //     mainObject.position.z + transformPos.z);
    //     // ball.position = ballPos;
    //
    //     // if (moveAble)
    //     // {
    //     //     originalPos = ball.position;
    //     // }
    //
    //     Debug.DrawLine(ball.position, transformPos, Color.green);
    //
    //     transform.position = originalPos;
    // }
}