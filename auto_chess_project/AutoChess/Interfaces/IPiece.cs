interface IPiece
{
    string PieceId {get;}
    string Name {get;}
    double Hp {get;}
    double Attack {get;}
    double Armor {get;}
    int AttackRange {get;}
    PieceTypes PieceType {get;}
    public void Skill();
    public string ToString();
}