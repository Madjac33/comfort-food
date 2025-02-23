using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject book;
    public GameObject kitchen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCooking(string dish) {
        book.transform.Translate(0, 1000, 0);
        kitchen.transform.Translate(0, 1000, 0);
    }
}
