using UnityEngine;

public class ScrollController : MonoBehaviour
{
    public int maxPage;
    private int currentPage;
    private Vector3 targetPos;
    public Vector3 pageStep;
    public RectTransform levelPagesRect;
    public float tweenTime;
    public LeanTweenType tweenType;

    private void Awake() {
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
    }

    public void Next() {
        if (currentPage < maxPage) {
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
    }

    public void Previous() {
        if (currentPage > 1) {
            currentPage --;
            targetPos -= pageStep;
            MovePage();
        }
    }

    public void MovePage() {
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
    }
}
