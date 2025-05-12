using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public static class GameFormulas
{
    //Funzioni Elementali
    
    // Verifica se l'elemento dell'attacco sfrutta la debolezza del difensore
    public static bool HasElementAdvantage(ELEMENT attackElement, Hero defender)
    {
        return attackElement == defender.Weakness;
    }

    // Verifica se l'elemento dell'attacco è resistito dal difensore
    public static bool HasElementDisadvantage(ELEMENT attackElement, Hero defender)
    {
        return attackElement == defender.Resistance;
    }

    // Calcola il moltiplicatore del danno in base agli elementi
    public static float EvaluateElementalModifier(ELEMENT attackElement, Hero defender)
    {
        if (HasElementAdvantage(attackElement, defender)) return 1.5f;
        if (HasElementDisadvantage(attackElement, defender)) return 0.5f;
        return 1f;
    }

    // Meccaniche di Combattimento
    
    // Determina se l'attacco colpisce in base a aim (attaccante) ed eva (difensore)
    public static bool HasHit(Stats attacker, Stats defender)
    {
        int hitChance = attacker.aim - defender.eva;
        hitChance = Mathf.Max(hitChance, 0); // Blocca valori negativi
        
        int randomRoll = Random.Range(0, 100);
        bool isHit = randomRoll <= hitChance;
        
        if (!isHit) Debug.Log("MISS");
        return isHit;
    }

    // Determina se l'attacco è un colpo critico
    public static bool IsCrit(int critValue)
    {
        int randomRoll = Random.Range(0, 100);
        bool isCrit = randomRoll < critValue;
        
        if (isCrit) Debug.Log("CRIT");
        return isCrit;
    }

    // Calcolo Danno Completo
    
    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        // 1. Calcolo statistiche combinate
        Stats attackerStats = Stats.Sum(attacker.BaseStats, attacker.Weapon?.BonusStats ?? new Stats());
        Stats defenderStats = Stats.Sum(defender.BaseStats, defender.Weapon?.BonusStats ?? new Stats());

        // 2. Selezione difesa in base al tipo di danno
        int defenseValue = attacker.Weapon.DmgType == Weapon.DAMAGE_TYPE.PHYSICAL ? 
            defenderStats.def : 
            defenderStats.res;

        // 3. Danno base (attacco - difesa)
        int baseDamage = Mathf.Max(attackerStats.atk - defenseValue, 0);

        // 4. Modificatori elementali
        float elementalMultiplier = EvaluateElementalModifier(attacker.Weapon.Element, defender);
        float modifiedDamage = baseDamage * elementalMultiplier;

        // 5. Gestione critico
        if (IsCrit(attackerStats.crt)) modifiedDamage *= 2;

        // 6. Arrotondamento e controllo finale
        return Mathf.Max(Mathf.RoundToInt(modifiedDamage), 0);
    }
}
