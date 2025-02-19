# Scaffolding (Reverse Engineering) DatabaseFirst
# sans argument no-onconfiguring (using ConnectionString dans la classe DBCOntext)
# dotnet ef dbcontext scaffold "Server=localhost;Database=FormationOumdinAcademy;User Id=sa;Password=Pass123@;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer --context-dir Infra --output-dir Entities --force 