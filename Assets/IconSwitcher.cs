using UnityEngine;
using UnityEngine.UI;

public class ToggleFirstImage : MonoBehaviour
{
    public Button myButton;
    public GameObject[] images; 

    void Start()
    {
        myButton.onClick.AddListener(ShowFirstImage);
    }

    void ShowFirstImage()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(i == 0); 
        }
    }
}
