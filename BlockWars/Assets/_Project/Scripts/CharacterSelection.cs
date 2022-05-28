using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSelection : MonoBehaviour
{

    public TextMeshProUGUI myText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("selectedCharacter").ToString() != myText.text){
            myText.text = PlayerPrefs.GetInt("selectedCharacter").ToString();
        }
    }
}
