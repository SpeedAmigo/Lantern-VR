using UnityEngine;

public class LiftButtonScript : MonoBehaviour
{
    [SerializeField] private LiftScript lift;
    [SerializeField] private PowerManager powerManager;
    
    public void StartLift()
    {
        if (powerManager.isPowered == true)
        {
            lift.StartLift();
        }
    }
}
