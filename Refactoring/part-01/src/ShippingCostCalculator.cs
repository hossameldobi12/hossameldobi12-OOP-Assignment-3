namespace RefactoringLab;

public interface IShippingCarrier
{
    decimal Calculate( decimal weightKg);
}
public class AramexCompany : IShippingCarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;  
    }
}
public class FedExCompany : IShippingCarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}
public class DHLCompany : IShippingCarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}
public class BostaCompany : IShippingCarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 10m;
    }
}

public class ShippingCostCalculator
{
    public decimal Calculate(IShippingCarrier carrier, decimal weightKg)
    {
        if(carrier == null)
        {
            throw new ArgumentNullException($"Unknown carrier: {carrier}");
        } 
        return carrier.Calculate(weightKg);
    }
}
