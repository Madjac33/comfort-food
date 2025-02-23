using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject book;
    public GameObject kitchen;
    public GameObject pbAndJ;
    public GameObject misoSoup;
    public GameObject spaghetti;
    public GameObject acaiBowl;
    public TMP_Text instruction;


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
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ReturnToBook();
        }
    }

    public void ReturnToBook() {
        HideIngredients();
        book.transform.Translate(0, -1000, 0);
        kitchen.transform.Translate(0, -1000, 0);
    }

    public void StartCooking(string dish) {
        book.transform.Translate(0, 1000, 0);
        kitchen.transform.Translate(0, 1000, 0);

        if (dish == "Miso soup") {
            instruction.text = "Use the ceramic bowl.";
            misoSoup.SetActive(true);
        }
        else if (dish == "Peanut butter and jelly") {
            instruction.text = "Use the cutting board.";
            pbAndJ.SetActive(true);
        }
        else if (dish == "Spaghetti") {
            instruction.text = "Use the pot on the stovetop.";
            spaghetti.SetActive(true);
        }
        else if (dish == "Acai bowl") {
            instruction.text = "Use the wooden bowl.";
            acaiBowl.SetActive(true);
        }
    }
}
