

public class TransportPris
{
    public int BeregnTransportpris(double afstand, double vægt)
    {
        if (afstand < 5)
        {
            if (vægt < 10)
            {
                return 0;
            }
            else
            {
                return 50;
            }
        }
        else 
        {
            if (vægt < 10)
            {
                return 75;
            }
            else
            {
                return 100;
            }
        }
    }
}