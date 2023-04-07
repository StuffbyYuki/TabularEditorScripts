There are multiple ways to format DAX in C# (https://docs.tabulareditor.com/te2/FormatDax.html)

___


## Good
- m.FormatDax();
- Model.AllMeasures.FormatDax();
- FormatDax(m);
- FormatDax(Model.AllMeasures);

## Bad
- m.Expression = FormatDax(m.Expression);

