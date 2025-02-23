using UnityEngine;

public class PageController : MonoBehaviour
{
    public GameObject content;
    // public GameObject image;
    // public GameObject background;
    // public GameObject flag;
    // public GameObject cook;

    public void HidePage() {
        if (content != null) {
            content.SetActive(false);
        }
        // title.SetActive(false);
        // if (image != null) {
        //     image.SetActive(false);
        // }
        // if (background != null) {
        //     background.SetActive(false);
        // }
        // if (flag != null) {
        //     background.SetActive(false);
        // }
        // if (cook != null) {
        //     background.SetActive(false);
        // }
    }

    public void RevealPage() {
        if (content != null) {
            content.SetActive(true);
        }
        // title.SetActive(true);
        // if (image != null) {
        //     image.SetActive(true);
        // }
        // if (background != null) {
        //     background.SetActive(true);
        // }
        // if (flag != null) {
        //     background.SetActive(true);
        // }
        // if (cook != null) {
        //     background.SetActive(true);
        // }
    }

}
