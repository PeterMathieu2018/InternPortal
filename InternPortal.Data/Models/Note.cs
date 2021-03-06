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

    // Note
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class Note
    {
        public int NoteId { get; set; } // NoteId (Primary key)
        public int ApplicationId { get; set; } // ApplicationId
        public string UserId { get; set; } // UserId (length: 128)
        public string Note_ { get; set; } // Note

        // Foreign keys

        /// <summary>
        /// Parent Application pointed by [Note].([ApplicationId]) (FK_dbo.Note_dbo.Application_ApplicationId)
        /// </summary>
        public virtual Application Application { get; set; } // FK_dbo.Note_dbo.Application_ApplicationId

        public Note()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
