using UnityEngine;

public class LiftButtonScript : MonoBehaviour
{
    [SerializeField] private LiftScript lift;
    
    public void StartLift()
    {
        lift.StartLift();
    }
}
