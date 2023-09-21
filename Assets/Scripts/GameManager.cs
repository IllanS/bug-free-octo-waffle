using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Player player;
    public GameObject censor;
    public GameObject texts;
    public GameObject startMenu;
    public GameObject gameUI;
    public GameObject attackChest;
    public GameObject armorChest;
    public GameObject auxChest;
    public GameObject defeat;
    public GameObject subjugate;
    public GameObject win;
    public GameObject gFight;
    public GameObject wFight;
    public GameObject oFight;
    public GameObject pFight;
    


    public Text display;
    public Text option1;
    public Text option2;
    public Text option3;
    public Text option4;

    public bool hasAttack;
    public bool hasArmor;
    public bool hasAux;
    public bool goblin;
    public bool wolf;
    public bool ogre;
    public bool possesed;

    int location;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        gameUI.SetActive(true);

        player = new Player();
        location = 0;
        goToLocation(0);
        goblin = true;
        wolf = true;
        ogre = true;
        possesed = true;
    }

    public void goToStart()
    {
        display.text = GameData.descriptions[0];
        option1.text = GameData.options[0, 0];
        option2.text = GameData.options[0, 1];
        option3.text = GameData.options[0, 2];
        option4.text = GameData.options[0, 3];
    }

    public void goToLocation(int newLoc)
    {
        attackChest.SetActive(false) ;
        armorChest.SetActive(false);
        auxChest.SetActive(false);
        location = newLoc;
        display.text = GameData.descriptions[location];
        option1.text = GameData.options[location, 0];
        option2.text = GameData.options[location, 1];
        option3.text = GameData.options[location, 2];
        option4.text = GameData.options[location, 3];
    }

    public void optionSelected(int index)
    {
        if (location == 0)
        {
            if (index == 0)
            {
                goToLocation(2);
                if (hasArmor == false)
                {
                    armorChest.SetActive(true);
                }
            }
            else if (index == 1)
            {
                goToLocation(4);
                if (goblin == true)
                {
                    gFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 2)
            {
                goToLocation(3);
                if (wolf == true)
                {
                    wFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 3)
            {

            }
            else { }
        }
        else if (location == 1)
        {
            if (index == 0)
            {
                goToLocation(4);
                if (goblin == true)
                {
                    gFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 1)
            {
                EndGame();
            }
            else if (index == 2)
            {

            }
            else if (index == 3)
            {

            }
            else { }
        }
        else if (location == 2)
        {
            if (index == 0)
            {
                goToLocation(0);
            }
            else if (index == 1)
            {
                goToLocation(4);
                if (goblin == true)
                {
                    gFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 2)
            {
                goToLocation(5);
                if (hasAux == false)
                {
                    auxChest.SetActive(true);
                }
            }
            else if (index == 3)
            {
                goToLocation(3);
                if (wolf == true)
                {
                    wFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else { }
        }
        else if (location == 3)
        {
            if (index == 0)
            {
                goToLocation(4);
                if (goblin == true)
                {
                    gFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 1)
            {
                goToLocation(5);
                if (hasAux == false)
                {
                    auxChest.SetActive(true);
                }
            }
            else if (index == 2)
            {
                goToLocation(2);
                if (hasArmor == false)
                {
                    armorChest.SetActive(true);
                }
            }
            else if (index == 3)
            {
                goToLocation(6);
                if (ogre == true)
                {
                    oFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else { }
        }
        else if (location == 4)
        {
            if (index == 0)
            {
                goToLocation(0);
            }
            else if (index == 1)
            {
                goToLocation(3);
                if (wolf == true)
                {
                    wFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 2)
            {
                goToLocation(1);
                if (hasAttack == false)
                {
                    attackChest.SetActive(true);
                }
            }
            else if (index == 3)
            {
                goToLocation(2);
                if (hasArmor == false)
                {
                    armorChest.SetActive(true);
                }
            }
            else { }
        }
        else if (location == 5)
        {
            if (index == 0)
            {
                goToLocation(2);
                if (hasArmor == false)
                {
                    armorChest.SetActive(true);
                }
            }
            else if (index == 1)
            {
                goToLocation(3);
                if (wolf == true)
                {
                    wFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 2)
            {

            }
            else if (index == 3)
            {

            }
            else { }
        }
        else if (location == 6)
        {
            if (index == 0)
            {
                goToLocation(7);
                if (possesed == true)
                {
                    pFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 1)
            {
                EndGame();
            }
            else if (index == 2)
            {

            }
            else if (index == 3)
            {

            }
            else { }
        }
        else if (location == 7)
        {
            if (index == 0)
            {
                goToLocation(6);
                if (ogre == true)
                {
                    texts.SetActive(false);
                    oFight.SetActive(true);
                    censor.SetActive(true);
                }
            }
            else if (index == 1)
            {
                
            }
            else if (index == 2)
            {

            }
            else if (index == 3)
            {
                EndGame();
            }
            else { }
        }

    }

    public void OpenChest1()
    {
        hasArmor = true;
        armorChest.SetActive(false);
    }
    public void OpenChest2()
    {
        hasAttack = true;
        attackChest.SetActive(false);
    }
    public void OpenChest3()
    {
        hasAux = true;
        auxChest.SetActive(false);
    }

    public void WolfFight()
    {
        if (hasArmor == true || hasAttack == true || hasAux == true)
        {
            subjugate.SetActive(true);
            wolf = false;
        }
        else { defeat.SetActive(true); }
    }

    public void OgreFight()
    {
        if (hasArmor == true || hasAttack == true || hasAux == true)
        {
            if (hasArmor == true && hasAttack == true) { subjugate.SetActive(true); ogre = false; }
            else if (hasArmor == true && hasAux == true) { subjugate.SetActive(true); ogre = false; }
            else if (hasAux == true && hasAttack) { subjugate.SetActive(true); ogre = false; }
        }
        else { defeat.SetActive(true); }
    }

    public void PossesedFight()
    {
        if (hasArmor == true && hasAttack == true && hasAux == true)
        {
            EndGame();
            possesed = false;
        }
        else { defeat.SetActive(true); }
    }
    public void EndGame()
    {
        win.SetActive(true);
    }
}
