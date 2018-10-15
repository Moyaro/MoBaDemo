﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 英雄单位,特殊的Character单位
/// </summary>
[Serializable]
public class HeroModel : CharacterModel{
    // 力量
    public float forcePower;
    // 力量成长
    public float forcePowerGrowthPoint;
    // 敏捷
    public float agilePower;
    // 敏捷成长
    public float agilePowerGrowthPoint;
    // 智力
    public float intelligencePower;
    // 智力成长
    public float intelligenceGrowthPoint;
    // 技能点
    public int skillPoint;
    // 技能点成长
    public int skillPointGrowthPoint;
    // 经验值
    public int exp;
    // 经验值因子（每次升级所需经验值关联系数）
    public float expfactor;
    // 升级所需经验值(指第0级升到第一级所需经验) 
    public float needExp;

    public override void Damaged(Damage damage) {
        base.Damaged(damage);
    }

    public override string ToString() {
        return "Name:" + name + " hp:" + Hp + " exp:" + exp;
    }
}

