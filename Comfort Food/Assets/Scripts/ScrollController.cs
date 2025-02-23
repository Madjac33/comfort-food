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
    private AudioSource audio;

    private void Start() {
        audio = GetComponent<AudioSource>();
    }

    private void Awake() {
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
    }

    private void PlayButtonSound() {
        audio.Play();
    }

    public void Next() {
        if (currentPage < maxPage) {
            currentPage++;
            targetPos += pageStep;
            audio.Play();
            MovePage();
        }
    }

    public void Previous() {
        if (currentPage > 1) {
            currentPage --;
            targetPos -= pageStep;
            audio.Play();
            MovePage();
        }
    }

    public void MovePage() {
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
    }
}
