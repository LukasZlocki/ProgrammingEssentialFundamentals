// Section: 38 "Magic number of the pattern"

class PriceCalculator
{

    // solution is to add const values, as variables, to Calculate classs
    const double vat5 = 0.05;
    const double vat8 = 0.08;
    const double vat18 = 0.18;

    public double Caculate(double basePrice, bool isFrozen, bool isBakedGoods)
    {
        if (isFrozen)
        {
            return basePrice * 1.05; // 1.05 magic number :)
        }
        if (isBakedGoods)
        {
            return basePrice + 1.08; // 1.18 magic number :)
        }
        return 1.18; // next agic number
    }
}