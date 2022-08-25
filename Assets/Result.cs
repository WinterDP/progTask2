using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Result", menuName = "progTask2/Result", order = 0)]
public class Result : ScriptableObject {
    [SerializeField] string effectName;
    [SerializeField] float magnitude;
    [SerializeField] float area;
    [SerializeField] float duration;
    [SerializeField] int cost;
    [SerializeField] string magicSchool;
}
