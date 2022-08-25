using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum enumEquipType
{
    SWORD,ARMOR,SHIELD,KEY_ITEM,COMMOM_ITEM
}

[CreateAssetMenu(fileName = "Ingredient", menuName = "progTask2/Ingredient", order = 0)]
public class Ingredient : ScriptableObject {
    //----------------------- general information ----------
    [SerializeField] string id;

    [SerializeField] new string name;
    
    [SerializeField] float weight;
    
    [SerializeField] float value;
    
    [SerializeField] enumEquipType equipType;
    //----------------------  menu image settings ---------------
    [SerializeField] string inventoryImagePath;
    
    [SerializeField] string messageIconPath;
    
    [SerializeField] Sprite inventoryImage;
    
    [SerializeField] Sprite messageIcon;
    //------------------- word art --------------------------

    [SerializeField] string modelPath;

    [SerializeField] MonoBehaviour destructionData;

    [SerializeField] bool referencesPersist;

    [SerializeField] bool foodItem;    

    //------------- audio settings ----------------------

    [SerializeField] AudioSource pickUpSound;

    [SerializeField] AudioSource putDownSound;

    //--------------- results ---------------------

    [SerializeField] List<Result> results;

    [SerializeField] bool autoCaulculate;

    [SerializeField] int ingredientValue;
    //------------------- scripts -----------------

    [SerializeField] List<MonoBehaviour> oldScripts;
    [SerializeField] List<MonoBehaviour> papyrusScripts;

    //------------ keywords --------------------
    
    [SerializeField] List<string> keywords;

    // ------------- description ---------------
    
    [SerializeField] string description;


}