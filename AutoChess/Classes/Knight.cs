using AutoChess;

public class Knight : Hero
{
	public Knight(string name, PieceTypes heroType, double hp, double attack, double armor, int attackRange) : base(name, heroType, hp, attack, armor, attackRange)
	{
	}
	
	public override void Skill(GameController gameController)
	{
		base.Skill(gameController);
	}
}