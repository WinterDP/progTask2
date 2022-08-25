using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum enumTeaches
{
    SKILL,SPELL
}

[CreateAssetMenu(fileName = "book", menuName = "progTask2/Book", order = 0)]
public class Book : ScriptableObject {
    //----------------------- general information ----------
    [SerializeField] string id;

    [SerializeField] new string name;
    
    [SerializeField] float weight;
    
    [SerializeField] float value;
    
    [SerializeField] enumTeaches teaches;
    //----------------------  menu image settings ---------------
    [SerializeField] string inventoryImagePath;
    
    [SerializeField] string messageIconPath;
    
    [SerializeField] Sprite inventoryImage;
    
    [SerializeField] Sprite messageIcon;
    //------------------- word art --------------------------

    [SerializeField] Sprite inventoryArt;

    [SerializeField] MonoBehaviour destructionData;

    [SerializeField] bool cantBeTaken;

    // ------------- audio settings

    [SerializeField] AudioSource pickUpSound;

    [SerializeField] AudioSource putDownSound;

    //-------------- book text -----------------------

    [SerializeField] string bookText;

    //------------------- scripts -----------------

    [SerializeField] List<MonoBehaviour> scripts;

    //------------ keywords --------------------
    
    [SerializeField] List<string> keywords;

    // ------------- description ---------------
    
    [SerializeField] string description;
    


}

