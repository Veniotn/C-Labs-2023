namespace Calculator;

public class TaxData
{
    private double provincialTaxWithheld;
    private double federalTaxWithheld;
    private double dependentDeduction;
    private double totalWithheld;
    private double totalTakeHome;


    public TaxData(double provincialTaxWithheld, double federalTaxWithheld, double dependentDeduction, double totalWithheld, double totalTakeHome)
    {
        this.provincialTaxWithheld = provincialTaxWithheld;
        this.federalTaxWithheld = federalTaxWithheld;
        this.dependentDeduction = dependentDeduction;
        this.totalWithheld = totalWithheld;
        this.totalTakeHome = totalTakeHome;
    }


    public double ProvincialTaxWithheld
    {
        get => provincialTaxWithheld;
        set => provincialTaxWithheld = value;
    }

    public double FederalTaxWithheld
    {
        get => federalTaxWithheld;
        set => federalTaxWithheld = value;
    }

    public double DependentDeduction
    {
        get => dependentDeduction;
        set => dependentDeduction = value;
    }

    public double TotalWithheld
    {
        get => totalWithheld;
        set => totalWithheld = value;
    }

    public double TotalTakeHome
    {
        get => totalTakeHome;
        set => totalTakeHome = value;
    }
}