using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards;




class Cards
{
public int Number;
public string FaceCards;
public string Joker;


public override string ToString()
{
    return "Oooppps";
}


}
class Hearts : Cards
{
public string Suit = "Hearts";
public string Color = "Red";

public Hearts(int num)
{
    Number = num;
}
public Hearts(string facecard)
{
    FaceCards = facecard;
}

public override string ToString()
{
    if (Number > 0)// can put null here work on this. put note here for memory help :) 
    {
        return $"This is the {Number} of {Suit}";
    }
    else
    {
        return $"This is the {FaceCards} of {Suit}";
    }
}

}
class Diamonds : Cards
{
public string Suit = "Diamonds";
public string Color = "Red";

public Diamonds(int num)
{
    Number = num;
}
public Diamonds(string facecard)
{
    FaceCards = facecard;
}
public override string ToString()
{
    if (Number > 0)
    {
        return $"This is the {Number} of {Suit}";
    }
    else
    {
        return $"This is the {FaceCards} of {Suit}";
    }
}

}
class Spades : Cards
{
public string Suit = "Spades";
public string Color = "Black";

public Spades(int num)
{
    Number = num;
}
public Spades(string facecard)
{
    FaceCards = facecard;
}

public override string ToString()
{
    if (Number > 0)
    {
        return $"This is the {Number} of {Suit}";
    }
    else
    {
        return $"This is the {FaceCards} of {Suit}";
    }
}

}
class Clubs : Cards
{
public string Suit = "Clubs";
public string Color = "Black";

public Clubs(int num)
{
    Number = num;
}
public Clubs(string facecard)
{
    FaceCards = facecard;
}

public override string ToString()
{
    if (Number > 0)
    {
        return $"This is the {Number} of {Suit}";
    }
    else
    {
        return $"This is the {FaceCards} of {Suit}";
    }
}

}
