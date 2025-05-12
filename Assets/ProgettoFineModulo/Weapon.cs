using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon
{
    public enum DAMAGE_TYPE
    {
        PHYSICAL,
        MAGICAL
    }

    [SerializeField] private string name;
    [SerializeField] private DAMAGE_TYPE dmgType;
    [SerializeField] private ELEMENT elem;
    [SerializeField] private Stats bonusStats;

    // Costruttore che inizializza tutti i campi
    public Weapon(string name, DAMAGE_TYPE dmgType, ELEMENT elem, Stats bonusStats)
    {
        this.name = name;
        this.dmgType = dmgType;
        this.elem = elem;
        this.bonusStats = bonusStats;
    }

    // Proprietà per l'accesso controllato ai campi privati
    public string Name
    {
        get => name;
        set => name = value;
    }

    public DAMAGE_TYPE DmgType
    {
        get => dmgType;
        set => dmgType = value;
    }

    public ELEMENT Element
    {
        get => elem;
        set => elem = value;
    }

    public Stats BonusStats
    {
        get => bonusStats;
        set => bonusStats = value;
    }
}


