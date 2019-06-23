# UnitsNet.EntityFrameworkCore

Functions/Methods to easily integrate UnitsNet with EntityFrameworkCore. Currently, this only has [Value Conversions](https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions). Feel free to open an issue if there are features we can add to this library.

## Install

Run the following command in your [Package Manager Console](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console):

  ```bash
  `install-package UnitsNet.EntityFrameworkCore`
  ```

## Value Conversion

```c#
builder.Property(x => x.MyLength).HasConversion(LengthUnit.Meter);
```

Full Sample:

```c#
using Microsoft.EntityFrameworkCore;
using UnitsNet;
using UnitsNet.EntityFrameworkCore;
using UnitsNet.Units;

public class FooContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Foo>(builder =>
        {
            builder.Property(x => x.MyLength).HasConversion(LengthUnit.Meter);
            builder.Property(x => x.MySpeed).HasConversion(SpeedUnit.KilometerPerHour);
        });
    }
}

public class Foo
{
    public Length MyLength { get; set; }
    public Speed MySpeed { get; set; }
}
```
