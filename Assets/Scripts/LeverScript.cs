using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(HingeJoint))]
public class LeverScript : MonoBehaviour
{
    private HingeJoint joint;

    public bool leverAtMax;
    public bool leverAtMin;
    
    [SerializeField] UnityEvent onLeverOn;
    [SerializeField] UnityEvent onLeverOff;

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

    private void LeverAtMin(float angle)
    {
        if (!leverAtMax && Mathf.Abs(angle - joint.limits.max) <= tolerance)
        {
            onLeverOff?.Invoke();
            leverAtMin = true;
        }
        else if (Mathf.Abs(angle - joint.limits.max) > tolerance)
        {
            leverAtMin = false;
        }
    }

    private void LeverAtMax(float angle)
    {
        if (Mathf.Abs(angle - joint.limits.min) <= tolerance && !leverAtMin)
        {
            onLeverOn?.Invoke();
            leverAtMax = true;
        }
        else if (Mathf.Abs(angle - joint.limits.min) > tolerance)
        {
            leverAtMax = false;
        }
    }
}
