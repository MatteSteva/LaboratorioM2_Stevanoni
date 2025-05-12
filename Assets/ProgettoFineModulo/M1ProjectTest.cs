using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class M1ProjectTest : MonoBehaviour
{
    [SerializeField] private Hero a;
    [SerializeField] private Hero b;

    private bool _roundInProgress;

    void Update()
    {
        // Blocca nuove round se uno dei due è morto o se un round è in corso
        if (!a.IsAlive() || !b.IsAlive() || _roundInProgress) return;
        
        _roundInProgress = true;
        ExecuteCombatRound();
        _roundInProgress = false;
    }

    private void ExecuteCombatRound()
    {
        // 1. Determina ordine di attacco in base alla velocità
        var (attacker1, attacker2) = GetAttackOrder();

        // 2. Primo attacco
        bool defender1Survived = HandleAttack(attacker1, attacker2);

        // 3. Secondo attacco solo se il difensore è sopravvissuto
        if (defender1Survived)
        {
            HandleAttack(attacker2, attacker1);
        }
    }

    private (Hero first, Hero second) GetAttackOrder()
    {
        int speedA = GetSpeed(a);
        int speedB = GetSpeed(b);

        return speedA >= speedB ? (a, b) : (b, a);
    }

    private int GetSpeed(Hero hero)
    {
        Stats totalStats = Stats.Sum(hero.BaseStats, hero.Weapon?.BonusStats ?? new Stats());
        return totalStats.spd;
    }

    private bool HandleAttack(Hero attacker, Hero defender)
    {
        Debug.Log($"<color=cyan>[ATTACK]</color> {attacker.Name} -> {defender.Name}");

        // 1. Verifica se il colpo va a segno
        Stats attackerStats = Stats.Sum(attacker.BaseStats, attacker.Weapon?.BonusStats ?? new Stats());
        Stats defenderStats = Stats.Sum(defender.BaseStats, defender.Weapon?.BonusStats ?? new Stats());
        
        if (!GameFormulas.HasHit(attackerStats, defenderStats))
        {
            Debug.Log("<color=yellow>MISS!</color>");
            return defender.IsAlive();
        }

        // 2. Logiche elementali
        ELEMENT attackElement = attacker.Weapon.Element;
        if (GameFormulas.HasElementAdvantage(attackElement, defender))
            Debug.Log("<color=red>WEAKNESS!</color>");
        else if (GameFormulas.HasElementDisadvantage(attackElement, defender))
            Debug.Log("<color=blue>RESIST!</color>");

        // 3. Calcolo danno
        int damage = GameFormulas.CalculateDamage(attacker, defender);
        Debug.Log($"<color=orange>Damage: {damage}</color>");
        defender.TakeDamage(damage);

        // 4. Controllo morte
        if (!defender.IsAlive())
            Debug.Log($"<color=red>[VICTORY] {attacker.Name} defeats {defender.Name}!</color>");

        return defender.IsAlive();
    }
}
