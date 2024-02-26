using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseProfile : MonoBehaviour
{
    public GameObject playerimage;
    public TextMeshProUGUI playerText;
    public float charwidth = 10f;
    //public RectTransform lengthTxt;

    private Image dummyImage;


    private void Awake()
    {
        dummyImage = playerimage.GetComponent<Image>();
    }

    public void Onclicked()
    {
        //Debug.Log(this.gameObject.transform.GetChild(0));
        RectTransform rectTransform = playerText.GetComponent<RectTransform>();
        float newWidth = charwidth * playerText.text.Length;


        Debug.Log(this.gameObject.name);
        dummyImage.sprite = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
        playerText.text = this.gameObject.name;
        Debug.Log(playerText.text);

    }

}
