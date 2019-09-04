using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;

public class TowerBase : MonoBehaviour {
    public TowerBaseSO towerBase;
    void Start () {
        Debug.Log(towerBase.towerMultiplier);
    }
}