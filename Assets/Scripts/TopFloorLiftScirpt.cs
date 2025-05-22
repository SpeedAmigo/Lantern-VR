using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class TopFlootLiftScript : MonoBehaviour
{
    [SerializeField] private float moveDuration = 10f;
    
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform targetPosition;
    
    [SerializeField] private DOTweenAnimation shakeAnimation;
    
    [SerializeField] private UnityEvent onLiftStart;
    [SerializeField] private UnityEvent onLiftComplete;

    private Tween moveTween;
    [SerializeField] private bool isMovingUp = false;
    public bool canBeMoved = true;
    
    [Button]
    public void StartLift()
    {
        if (Mathf.Approximately(transform.position.y, targetPosition.position.y)) return;
        if (!canBeMoved) return;
        if (isMovingUp) return;
        
        moveTween = transform.DOMove(targetPosition.position, moveDuration)
            .SetEase(Ease.InOutQuad)
            .OnStart(() => OnStart())
            .OnComplete(() => Complete());
    }

    [Button]
    public void StartLiftBackwards()
    {
        if (Mathf.Approximately(transform.position.y, startPosition.position.y)) return;
        if (!canBeMoved) return;
        if (isMovingUp) return;
        
        moveTween = transform.DOMove(startPosition.position, moveDuration)
            .SetEase(Ease.InOutQuad)
            .OnStart(() => OnStart())
            .OnComplete(() => Complete());
    }

    public void CanBeMoved(bool value)
    {
        canBeMoved = value;
    }

    private void OnStart()
    {
        isMovingUp = true;
        onLiftStart?.Invoke();
    }
    
    private void Complete()
    {
        isMovingUp = false;
        onLiftComplete?.Invoke();
    }
}