﻿namespace Projeto
{
    public class Knigth : Hero
    {
        public Knigth(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}