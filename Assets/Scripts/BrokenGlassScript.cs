using UnityEngine;
using DG.Tweening;

public class BrokenGlassScript : MonoBehaviour
{
    [SerializeField] private GameObject[] glassPieces;

    private void OnEnable()
    {
        foreach(GameObject piece in glassPieces)
        {
            ScaleDownAndDisable(piece);
        }
    }

    private void ScaleDownAndDisable(GameObject piece)
    {
        piece.transform.DOScale(Vector3.zero, 2f).SetDelay(5f).OnComplete(() => piece.SetActive(false));
        
    }
}
