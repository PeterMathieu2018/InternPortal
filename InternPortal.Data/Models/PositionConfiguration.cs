// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace InternPortal.Data.Models
{

    // Position
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class PositionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
            : this("dbo")
        {
        }

        public PositionConfiguration(string schema)
        {
            ToTable("Position", schema);
            HasKey(x => x.PositionId);

            Property(x => x.PositionId).HasColumnName(@"PositionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PositionName).HasColumnName(@"PositionName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.PositionDescription).HasColumnName(@"PositionDescription").HasColumnType("nvarchar(max)").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
