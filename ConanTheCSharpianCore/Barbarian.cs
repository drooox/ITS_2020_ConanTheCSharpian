﻿

using System.Collections.Generic;

namespace ConanTheCSharpian.Core
{
    public class Barbarian : Hero
    {
        public Barbarian()
        {
            Name = "Conan";
            Damage = 30;
            MaxHealth = 120;
            Accuracy = 0.6f;
        }

        public override void PerformSpecialAction()
        {
            // TODO: implement special action logic
            DamageSp = 60;
            AccuracySp = 0.3f;

            

            Battlefield.DisplayMessage($"{FullyQualifiedName} just used his special action with double damage!");
        }
    }
}
