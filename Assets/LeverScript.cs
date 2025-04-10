using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class LeverScript : MonoBehaviour
{
    private HingeJoint joint;

    public bool leverAtMax;
    public bool leverAtMin;

    private float tolerance = 0.5f;

    private void Awake()
    {
        joint = GetComponent<HingeJoint>();
    }

    void Update()
    {
        LeverAtMax(LeverAngle());
        LeverAtMin(LeverAngle());
    }

    private float LeverAngle()
    {
        return joint.angle;
    }

    private void LeverAtMax(float angle)
    {
        if (Mathf.Abs(angle - joint.limits.max) <= tolerance && !leverAtMax)
        {
            Debug.Log("On");
            leverAtMax = true;
        }
        else
        {
            leverAtMax = false;
        }
    }

    private void LeverAtMin(float angle)
    {
        if (Mathf.Abs(angle + joint.limits.min) <= tolerance && !leverAtMin)
        {
            Debug.Log("Off");
            leverAtMin = true;
        }
        else
        {
            leverAtMin = false;
        }
    }
}
