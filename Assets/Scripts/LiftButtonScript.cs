using UnityEngine;

public class LiftButtonScript : MonoBehaviour
{
    [SerializeField] private LiftScript lift;
    [SerializeField] private PowerManager powerManager;

    [SerializeField] private bool usePower = true;
    
    public void StartLift()
    {
        if (usePower == true)
        {
            if (powerManager.isPowered == true)
            {
                lift.StartLift();
            }
        }

        if (usePower == false)
        {
            lift.StartLift();
        }
    }
}
