using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Perso_Info_Printing : MonoBehaviour
{
    public GameObject lifeText;
    public GameObject failMenu;
    public int nbOfLives;
    // Start is called before the first frame update
    void Start()
    {
        failMenu.gameObject.SetActive(false);
        Time.timeScale = 1f;
        lifeText.GetComponent<TextMeshProUGUI>().text = "x"+nbOfLives.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Vide" && nbOfLives>0)
        {
            nbOfLives--;
            lifeText.GetComponent<TextMeshProUGUI>().text = "x"+nbOfLives.ToString();
        }
        else
        {
            failMenu.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
