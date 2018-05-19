using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class CharacterCreator : MonoBehaviour {
    string LoginURL = "http://localhost/rpg/CharacterCreator.php";

    private GameObject CharacterClass;
    private GameObject CharacterType;
    public Button SubmitButton;
    public GameObject Mag;
    public GameObject Archer;
    public GameObject Warrior;
    public GameObject Berserker;
    public GameObject Human;
    public GameObject Ork;

    private string characterClass;
    private string characterType;
    private string hair_color;
    private int i=0;

    public SpriteRenderer Thin;
    public Color red;
    public Color yellow;

    void Start()
    {

        if (i == 0)
        {
          
            SubmitButton.onClick.AddListener(Click_Button);
            i++;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Click_Button()
    {
        characterClass = CharacterClass.ToString();
        characterType = CharacterType.ToString();
        
        Debug.Log(hair_color);
        StartCoroutine(CreateCharacter(characterClass, characterType, hair_color));
    }

    IEnumerator CreateCharacter(string classLink, string typeLink, string hairColor)
    {
        WWWForm form = new WWWForm();

        form.AddField("classPost", classLink);

        form.AddField("typePost", typeLink);

        form.AddField("hairColorPost", hairColor);

        WWW www = new WWW(LoginURL, form);

        yield return www;

        Debug.Log(www.text);
    }

   
    public void WarriorSelecter()
    {
        CharacterClass = Warrior;

    }
    public void ArcherSelecter()
    {
        CharacterClass = Archer;
    }
    public void BerserkerSelecter()
    {
        CharacterClass = Berserker;
    }
    public void MagSelecter()
    {
        CharacterClass = Mag;
    }
    public void HumanSelecter()
    {
        CharacterType = Human;
    }
    public void OrkSelecter()
    {
        CharacterType = Ork;
    }

    public void Yellow()
    {
        hair_color = "yellow";
        Thin.color = yellow;
    }

    public void Red()
    {
        hair_color = "red";
        Thin.color = red;
    }

}
