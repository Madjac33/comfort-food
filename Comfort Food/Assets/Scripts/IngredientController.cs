using UnityEngine;
using UnityEngine.EventSystems;

public class IngredientController : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnAwake()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void SetStartPosition() {
    //     startPos = transform.position;
    // }

    void ResetPosition() {
        transform.position = startPos;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        startPos = transform.position;
        // if (!match) {
        //     transform.DOScale(newScale, 1.0f);


        //     parentAfterDrag = transform.parent;
        //     transform.SetParent(transform.root);
        //     transform.SetAsLastSibling();
        //     image.raycastTarget = false;
        //     PlaySound();
        // }
    }

    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
        // if (!match) {
        //     transform.position = Input.mousePosition;
        // }
    }

    public void OnEndDrag(PointerEventData eventData) {
        ResetPosition();
        // transform.DOScale(originalScale, 1.0f).SetEase(Ease.OutBounce);
        
        // if (animalId == mysteryAnimal.GetId() && distance <= 50.0f) {
        //     transform.position = mysteryAnimalPos.position;
        //     narrator.GreatJob();
        // }
        // // Otherwise, return to original position
        // else if (animalId != mysteryAnimal.GetId()) {
        //     narrator.TryAgain();
        //     ReturnToStartPos();
        // }
        // else {
        //     ReturnToStartPos();
        // }
        // image.raycastTarget = true;
    }
}
