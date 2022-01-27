using System;
using TechTalk.SpecFlow;
using HeroTest;

namespace SpecflowGame.StepDefinitions
{ 
    [Binding]
    public class GameStepDefinitions
    {
        Hero hero = new Hero();
        int heroFullHP = 100;
        Enemy enemy = new Enemy();
        [Given(@"the hero has (.*) hp, (.*) Atk, (.*) Def")]
        public void GivenTheHeroHasHpAtkDef(int p0, int p1, int p2)
        {
            hero.HP = p0;
            hero.Atk = p1;
            hero.Def = p2;
            heroFullHP = p0;
        }

        [Given(@"the enemy has (.*) hp, (.*) Atk, (.*) Def")]
        public void GivenTheEnemyHasHpAtkDef(int p0, int p1, int p2)
        {
            enemy.HP = p0;
            enemy.Atk = p1;
            enemy.Def = p2;
        }

        [When(@"the enemy attacks")]
        public void WhenTheEnemyAttacks()
        {
            enemy.Attack(hero);
        }

        [Then(@"the hero should survive unharmed")]
        public void ThenTheHeroShouldSurviveUnharmed()
        {
            hero.HP.Should().Be(heroFullHP);

        }
        [Then(@"the hero should survive with (.*) HP")]
        public void ThenTheHeroShouldSurviveWith75HP(int p0)
        {
            hero.HP.Should().Be(p0);
        }
        [Then(@"the hero should be less than (.*)")]
        public void ThenTheHeroShouldBeLessThan(int p0)
        {
            hero.HP.Should().BeLessThanOrEqualTo(p0);
        }

    }
}
