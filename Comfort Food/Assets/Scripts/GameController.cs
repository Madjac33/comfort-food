using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject book;
    public GameObject kitchen;
    public GameObject pbAndJ;
    public GameObject misoSoup;
    public GameObject spaghetti;
    public GameObject acaiBowl;
    public GameObject pbAndJDish;
    public GameObject misoSoupDish;
    public GameObject spaghettiDish;
    public GameObject acaiBowlDish;
    public TMP_Text instruction;
    public Button next;
    public Button previous;
    public int ingredientCount;
    public int maxIngredientCount = 100;
    public AudioSource audio;
    private string mainDish;
    private bool begin = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HideIngredients();
        audio = GetComponent<AudioSource>();
    }

    void HideIngredients() {
        pbAndJ.SetActive(false);
        misoSoup.SetActive(false);
        spaghetti.SetActive(false);
        acaiBowl.SetActive(false);

        pbAndJDish.SetActive(false);
        misoSoupDish.SetActive(false);
        spaghettiDish.SetActive(false);
        acaiBowlDish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ReturnToBook();
            UnlockSurface();
        }
        if (ingredientCount >= maxIngredientCount) {
            instruction.text = "Great job! Press 'r' to play again.";
            if (mainDish == "Miso soup") {
                misoSoupDish.SetActive(true);
                misoSoup.SetActive(false);
            }
            else if (mainDish == "Peanut butter and jelly") {
                pbAndJDish.SetActive(true);
                pbAndJ.SetActive(false);
            }
            else if (mainDish == "Spaghetti") {
                spaghettiDish.SetActive(true);
                spaghetti.SetActive(false);
            }
            else if (mainDish == "Acai bowl") {
                acaiBowlDish.SetActive(true);
                acaiBowl.SetActive(false);
            }
        }
    }

    public void ReturnToBook() {
        HideIngredients();
        book.transform.Translate(0, -1000, 0);
        kitchen.transform.Translate(0, -1000, 0);
    }

    public void StartCooking(string dish) {
        mainDish = dish;
        begin = true;
        book.transform.Translate(0, 1000, 0);
        kitchen.transform.Translate(0, 1000, 0);

        if (dish == "Miso soup") {
            instruction.text = "Use the ceramic bowl.";
            misoSoup.SetActive(true);
            maxIngredientCount = 3;
        }
        else if (dish == "Peanut butter and jelly") {
            instruction.text = "Use the cutting board.";
            pbAndJ.SetActive(true);
            maxIngredientCount = 3;
        }
        else if (dish == "Spaghetti") {
            instruction.text = "Use the pot on the stovetop.";
            spaghetti.SetActive(true);
            maxIngredientCount = 4;
        }
        else if (dish == "Acai bowl") {
            instruction.text = "Use the wooden bowl.";
            acaiBowl.SetActive(true);
            maxIngredientCount = 3;
        }
    }

    public void LockSurface() {
        next.interactable = false;
        previous.interactable = false;
    }

    public void UnlockSurface() {
        next.interactable = true;
        previous.interactable = true;
    }
}
