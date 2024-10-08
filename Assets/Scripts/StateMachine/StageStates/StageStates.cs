using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageStates : StateBase
{
    
}

public class ValueStage : StageStates
{
    private Player player;
    private Enemy enemy;
    public override void OnStateEnter(params object[] objs)
    {
        base.OnStateEnter(objs);
        player = (Player)objs[0];
        enemy = (Enemy)objs[1];

        player.selected = false;
        enemy.selected = false;
        player.CurrentSelectedPos = 1;
        enemy.CurrentSelectedPos = 1;
    }
}

public class EffectStage : StageStates
{
    private Player player;
    private Enemy enemy;
    public override void OnStateEnter(params object[] objs)
    {
        base.OnStateEnter(objs);
        player = (Player)objs[0];
        enemy = (Enemy)objs[1];

        player.selected = false;
        enemy.selected = false;
        player.CurrentSelectedPos = 2;
        enemy.CurrentSelectedPos = 2;
    }
}