public interface ISettableCharacterStatus
{
    int HP{get; set;}
    int MP{get; set;}
    int ATK{get; set;}
    int DEF{get; set;}
    int INT{get; set;}
    int RES{get; set;}
    int SPD{get; set;}
        
}

public interface IReadOnlyCharacterStatus
{
    int HP{get;}
    int MP{get;}
    int ATK{get;}
    int DEF{get;}
    int INT{get;}
    int RES{get;}
    int SPD{get;}
}


public interface ICharacterStatus
{
    void Damage(int point);
}