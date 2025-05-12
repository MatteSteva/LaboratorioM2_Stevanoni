using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Hero
{
    [SerializeField] private string name;
    [SerializeField] private int hp;
    [SerializeField] private Stats baseStats;
    [SerializeField] private ELEMENT resistance;
    [SerializeField] private ELEMENT weakness;
    [SerializeField] private Weapon weapon;

    // Costruttore che inizializza tutti i campi
    public Hero(string name, int hp, Stats baseStats, ELEMENT resistance, ELEMENT weakness, Weapon weapon)
    {
        this.name = name;
        this.hp = hp;
        this.baseStats = baseStats;
        this.resistance = resistance;
        this.weakness = weakness;
        this.weapon = weapon;
    }

    // Metodo privato per impostare gli hp con controllo minimo
    private void SetHp(int newHp)
    {
        hp = Mathf.Max(newHp, 0); // Impedisce hp negativi
    }

    // Getter e Setter
    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Hp => hp; // Espone solo il getter per proteggere la modifica diretta

    public Stats BaseStats
    {
        get => baseStats;
        set => baseStats = value;
    }

    public ELEMENT Resistance
    {
        get => resistance;
        set => resistance = value;
    }

    public ELEMENT Weakness
    {
        get => weakness;
        set => weakness = value;
    }

    public Weapon Weapon
    {
        get => weapon;
        set => weapon = value;
    }

    // Funzioni per gestione HP
    public void AddHp(int amount)
    {
        SetHp(hp + amount);
    }

    public void TakeDamage(int damage)
    {
        AddHp(-damage); // Sottrae i danni chiamando AddHp con valore negativo
    }

    public bool IsAlive()
    {
        return hp > 0;
    }
}