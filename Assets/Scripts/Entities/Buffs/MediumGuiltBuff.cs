public class MediumGuiltBuff : EffectBase
{
    private int damageResist;
    private int debuffDamage;
    public MediumGuiltBuff(Entity entity, int debuffDamage, int damageResist, TypeOfEffect type) : base(entity, type)
    {
    }

    public override void ApplyAttackEffect()
    {
        entity.RemoveEffect(entity.selectedCards[1].Effect);
        entity.selectedCards[1].Damage -= debuffDamage;
        entity.selectedCards[1].Ability();
    }

    public override void ApplyDefenseEffect()
    {
        entity.damageResist += damageResist;
    }

    public override void RemoveAttackEffect()
    {
        entity.selectedCards[1].Damage += debuffDamage;
    }

    public override void RemoveDefenseEffect()
    {
        entity.damageResist -= damageResist;
    }

    public override void Render()
    {
        throw new System.NotImplementedException();
    }
}
