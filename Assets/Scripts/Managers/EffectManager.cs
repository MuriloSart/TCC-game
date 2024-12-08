public class EffectManager : Singleton<EffectManager>
{
    public void TakeEffect(Entity entity, EffectBase effect)
    {
        effect.ApplyEffect();
        entity.effects.Add(effect);
    }

    public void TakeEffectOverTurn(EffectBase effect)
    {
        if (effect.Turns > 1)
        {
            effect.DiscountingTurn();
            effect.EffectOverTime();
        }
        else if (effect.Turns == 1)
        {
            effect.EffectOverTime();
        }
        else
            effect.EffectOverTime();

    }

    public void RemoveAllEffects(Entity entity)
    {
        for (int i = entity.effects.Count - 1; i >= 0; i--)
        {
            if (entity.effects[i].Turns == 1)
                RemoveEffect(entity, entity.effects[i]);
        }
    }

    public void RemoveEffect(Entity entity, EffectBase effect)
    {
        effect.RemoveEffect();
        entity.effects.Remove(effect);
    }
}
