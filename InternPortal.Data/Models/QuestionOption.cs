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

    // QuestionOption
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class QuestionOption
    {
        public int OptionId { get; set; } // OptionId (Primary key)
        public int QuestionId { get; set; } // QuestionId
        public string OptionValue { get; set; } // OptionValue

        // Reverse navigation

        /// <summary>
        /// Child Answers where [Answer].[OptionId] point to this entity (FK_dbo.Answer_dbo.QuestionOption_OptionId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Answer> Answers { get; set; } // Answer.FK_dbo.Answer_dbo.QuestionOption_OptionId

        // Foreign keys

        /// <summary>
        /// Parent Question pointed by [QuestionOption].([QuestionId]) (FK_dbo.QuestionOption_dbo.Question_QuestionId)
        /// </summary>
        public virtual Question Question { get; set; } // FK_dbo.QuestionOption_dbo.Question_QuestionId

        public QuestionOption()
        {
            Answers = new System.Collections.Generic.List<Answer>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
