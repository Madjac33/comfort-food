using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject book;
    public GameObject kitchen;
    public GameObject pbAndJ;
    public GameObject misoSoup;
    public GameObject spaghetti;
    public GameObject acaiBowl;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HideIngredients();
    }

    void HideIngredients() {
        pbAndJ.SetActive(false);
        misoSoup.SetActive(false);
        spaghetti.SetActive(false);
        acaiBowl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCooking(string dish) {
        book.transform.Translate(0, 1000, 0);
        kitchen.transform.Translate(0, 1000, 0);

        if (dish == "Miso soup") {
            misoSoup.SetActive(true);
        }
        else if (dish == "Peanut butter and jelly") {
            pbAndJ.SetActive(true);
        }
        else if (dish == "Spaghetti") {
            spaghetti.SetActive(true);
        }
        else if (dish == "Acai bowl") {
            acaiBowl.SetActive(true);
        }
    }
}
