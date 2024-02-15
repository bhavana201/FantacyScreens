using TMPro;
using UnityEngine;

public class ChangeC_VC : MonoBehaviour
{
    public TextMeshProUGUI t1;
    public GameObject image;
    public TextMeshProUGUI t2;
    public GameObject image2;
    public TextMeshProUGUI t3;
    public GameObject image3;
    public TextMeshProUGUI t4;
    public GameObject image4;
    public TextMeshProUGUI t5;
    public GameObject image5;
    public TextMeshProUGUI t6;
    public GameObject image6;
    public TextMeshProUGUI t7;
    public GameObject image7;
    public TextMeshProUGUI t8;
    public GameObject image8;
    public TextMeshProUGUI t9;
    public GameObject image9;
    public TextMeshProUGUI t10;
    public GameObject image10;
    public TextMeshProUGUI t11;
    public GameObject image11;
    public string[] randomTexts; // Array to hold your random texts

    void Start()
    {
        // Call function to change text when the game starts
        ChangeTextRandomly();
    }

    public void ChangeTextRandomly()
    {
        image.SetActive(true);
        image2.SetActive(true);
        image3.SetActive(true);
        image4.SetActive(true);
        image5.SetActive(true);
        image6.SetActive(true);
        image7.SetActive(true);
        image8.SetActive(true);
        image9.SetActive(true);
        image10.SetActive(true);
        image11.SetActive(true);


        // Generate a random index within the range of the array

        int randomIndex = Random.Range(0, randomTexts.Length);
        /*if (randomTexts == randomTexts)
        {

        }*/

        // Set the text to a random text from the array
        t1.text = randomTexts[randomIndex];
        t2.text = randomTexts[randomIndex];
        t3.text = randomTexts[randomIndex];
        t4.text = randomTexts[randomIndex];
        t5.text = randomTexts[randomIndex];
        t6.text = randomTexts[randomIndex];
        t7.text = randomTexts[randomIndex];
        t8.text = randomTexts[randomIndex];
        t9.text = randomTexts[randomIndex];
        t10.text = randomTexts[randomIndex];
        t11.text = randomTexts[randomIndex];

    }
}
