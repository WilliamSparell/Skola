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

Scenario: Hero attacks weak enemy
	Given the hero has 100 hp, 50 Atk, 50 Def
	And the enemy has 30 hp, 15 Atk, 20 Def
	When the hero attacks
	Then the enemy will have less than 0 HP

Scenario: Hero attacks not so weak enemy
	Given the hero has 100 hp, 50 Atk, 50 Def
	And the enemy has 50 hp, 15 Atk, 20 Def
	When the hero attacks
	Then the enemy will have 20 HP

Scenario: Hero meets a boss enemy again
	Given the hero has 100 hp, 50 Atk, 50 Def
	And the enemy has 100 hp, 149 Atk, 150 Def
	When the enemy attacks
	Then the hero should survive with 1 HP