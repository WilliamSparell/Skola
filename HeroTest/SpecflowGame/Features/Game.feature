Feature: Game

@mytag
Scenario: Hero meets a weak enemy
	Given the hero has 100 hp, 50 Atk, 50 Def
	And the enemy has 30 hp, 15 Atk, 20 Def
	When the enemy attacks
	Then the hero should survive unharmed

Scenario: Hero meets a weak enemy again
	Given the hero has 100 hp, 50 Atk, 50 Def
	And the enemy has 30 hp, 75 Atk, 20 Def
	When the enemy attacks
	Then the hero should survive with 75 HP

Scenario: Hero meets a boss enemy
	Given the hero has 100 hp, 50 Atk, 50 Def
	And the enemy has 100 hp, 151 Atk, 150 Def
	When the enemy attacks
	Then the hero should be less than 0