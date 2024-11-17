﻿internal class HighLoveBuff : EffectBase
{

    public HighLoveBuff(Entity entity, TypeOfEffect type) : base(entity, type)
    {
        this.entity = entity;
    }

    public override void ApplyAttackEffect()
    {
        entity.health.Heal(entity.health.startLife / 2);
    }

    public override void ApplyDefenseEffect()
    {
        entity.health.Heal(entity.health.startLife / 2);
    }

    public override void RemoveAttackEffect()
    {
        return;
    }

    public override void RemoveDefenseEffect()
    {
        return;
    }

    public override void Render()
    {
        throw new System.NotImplementedException();
    }
}